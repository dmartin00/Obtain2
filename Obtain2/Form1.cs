using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using DocuSign.eSign;
using DocuSign.eSign.Client.Auth;
using DocuSign.eSign.Client;
using DocuSign.eSign.Api;
using DocuSign.eSign.Model;


namespace Obtain2
{


    
    public partial class Form1 : Form
    {
        
        string integratorKey = "";
        string oauthBasePath = "";
        string host = "";
        string accountId = "";
        string baseUri = "";
        bool authorized = false;
        int throttleSleepTime = 1000; //in MS
        

        OAuth.OAuthToken oAuthToken = new OAuth.OAuthToken();
        ApiClient apiClient = new ApiClient();
        EnvelopesApi envelopesApi = new EnvelopesApi();
        EnvelopesInformation envelopeList = new EnvelopesInformation();
        List<Envelope> envelopes = new List<Envelope>();

        EnvelopesApi.ListRecipientsOptions listRecipientsOptions = new EnvelopesApi.ListRecipientsOptions() { includeTabs = "true" };
        EnvelopesApi.ListStatusChangesOptions lcso = new EnvelopesApi.ListStatusChangesOptions();
  
        System.Configuration.Configuration configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                        
        public Form1()
        {
            
            InitializeComponent();
            toDateText.Text = DateTime.Today.ToString("yyyy-MM-dd");
            outPath.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "obtain.csv");
        }

        private void buttonStage_CheckedChanged(object sender, EventArgs e)
        {
            oauthBasePath = "account-s.docusign.com";
            host = "https://stage.docusign.com";
            userIdTextbox.Text = configuration.AppSettings.Settings["stageUser"].Value.ToString();
            iKeyBox.Text = configuration.AppSettings.Settings["stageIkey"].Value.ToString();
            privateKeyBox.Text = configuration.AppSettings.Settings["stageKeypath"].Value.ToString();
            if (String.IsNullOrEmpty(privateKeyBox.Text)) { privateKeyBox.Text = privateKeyBox.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PrivateKey-stage.txt"); };
            authorized = false; authStatusLabel.Text = authorized.ToString();
        }

        private void buttonDemo_CheckedChanged(object sender, EventArgs e)
        {
            oauthBasePath = "account-d.docusign.com";
            host = "https://demo.docusign.net";
            userIdTextbox.Text = configuration.AppSettings.Settings["DemoUser"].Value.ToString();
            iKeyBox.Text = configuration.AppSettings.Settings["demoIkey"].Value.ToString();
            privateKeyBox.Text = configuration.AppSettings.Settings["demoKeypath"].Value.ToString();
            if (String.IsNullOrEmpty(privateKeyBox.Text)) { privateKeyBox.Text = privateKeyBox.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PrivateKey-demo.txt"); };
            authorized = false; authStatusLabel.Text = authorized.ToString();
        }

        private void buttonProd_CheckedChanged(object sender, EventArgs e)
        {
            oauthBasePath = "account.docusign.com";
            host = "https://www.docusign.net";
            userIdTextbox.Text = configuration.AppSettings.Settings["prodUser"].Value.ToString();
            iKeyBox.Text = configuration.AppSettings.Settings["prodIkey"].Value.ToString();
            privateKeyBox.Text = configuration.AppSettings.Settings["prodKeypath"].Value.ToString();
            if(String.IsNullOrEmpty(privateKeyBox.Text)){ privateKeyBox.Text = privateKeyBox.Text = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PrivateKey-prod.txt"); };
            authorized = false; authStatusLabel.Text = authorized.ToString();
        }


        private void attemptAuth()
        {
            byte[] keyBytes = new byte[] { };
            try
            {
                keyBytes = File.ReadAllBytes(privateKeyBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Key read failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                apiClient = new ApiClient(host);
                oAuthToken = apiClient.RequestJWTUserToken(iKeyBox.Text, userIdTextbox.Text, oauthBasePath, keyBytes, 1);
            }
            catch (Exception ex)
            {
                if (MessageBox.Show("Click OK if this is a consent error and you would like to copy your consent url: " + ex.Message, "Token Request failed", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    List<string> scopes = new List<string>();
                    scopes.Add("Signature");
                    scopes.Add("Impersonation");
                    string redirectURI = "https://www.example.com";
                    Uri authUri = apiClient.GetAuthorizationUri(integratorKey, scopes, redirectURI, "code");
                    Clipboard.SetText(authUri.ToString());
                } //Consent IF
            } // token request exception
            OAuth.UserInfo userInfo = apiClient.GetUserInfo(oAuthToken.access_token);
            foreach (var item in userInfo.Accounts)
            {
                if (item.IsDefault == "true")
                {
                    accountId = item.AccountId;
                    apiClient = new ApiClient(item.BaseUri + "/restapi");
                    baseUri = item.BaseUri + @"/restapi";
                    authorized = true;
                    break;
                }
            }
            authStatusLabel.Text = authorized.ToString();
            envelopesApi = new EnvelopesApi(apiClient.Configuration);
        }
        private void authButton_Click(object sender, EventArgs e)
        {
            attemptAuth();
        } //auth button click

        private void countButton_Click(object sender, EventArgs e)
        {
            lcso.count = "50";
            lcso.searchText = subjectText.Text;
            lcso.fromDate = fromDateText.Text;
            //lcso.count = perPageCount.ToString();
            lcso.include = "envelope_folders";
            //lcso.startPosition = startCount;
            //lcso.folderTypes = "inbox,normal";
            lcso.toDate = toDateText.Text;
            //lcso.queryBudget = "500";
            if (!authorized)
            {
                attemptAuth();
            }

            try
            {
                envelopeList = envelopesApi.ListStatusChanges(accountId, lcso);
                countLabel.Text = envelopeList.TotalSetSize;
                exampleEnvelope.Text = envelopeList.Envelopes[0].EnvelopeId;
                envelopes = envelopeList.Envelopes;
            }
            catch (DocuSign.eSign.Client.ApiException ex)
            {
                if (MessageBox.Show("Click OK to attempt auth: " + ex.Message, "Envelope Query failed", MessageBoxButtons.OKCancel) == DialogResult.OK)
                { attemptAuth(); }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No results or something: " + ex.Message, "Null Reference Exception", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void PullFormDataButton_Click(object sender, EventArgs e)
        {
            Recipients recipients = envelopesApi.ListRecipients(accountId, exampleEnvelope.Text, listRecipientsOptions);

            try
            {
                foreach (Signer s in recipients.Signers)
                {
                    try
                    {
                        foreach (Text t in s.Tabs.TextTabs)
                        {
                            AddActiveLabel(t.TabLabel);
                        }
                    }
                    catch (System.NullReferenceException)
                    {
                        //MessageBox.Show("Exception: Envelope doesn't have textTabs tags or something", "NullReferenceException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    try
                    {
                        foreach (DocuSign.eSign.Model.List l in s.Tabs.ListTabs)
                        {
                            AddActiveLabel(l.TabLabel);
                        }
                    }
                    catch (System.NullReferenceException)
                    {
                        //MessageBox.Show("Exception: Envelope doesn't have textTabs tags or something", "NullReferenceException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    try
                    {
                        foreach (Checkbox c in s.Tabs.CheckboxTabs)
                        {
                            AddActiveLabel(c.TabLabel);
                        }
                    }
                    catch (System.NullReferenceException)
                    {
                        //MessageBox.Show("Exception: Envelope doesn't have textTabs tags or something", "NullReferenceException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                    try
                    {
                        foreach (DocuSign.eSign.Model.FormulaTab f in s.Tabs.FormulaTabs)
                        {
                            AddActiveLabel(f.TabLabel);
                        }
                    }
                    catch (System.NullReferenceException)
                    {
                        //MessageBox.Show("Exception: Envelope doesn't have textTabs tags or something", "NullReferenceException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //return;
                    }
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Exception: Envelope doesn't have signers or something", "NullReferenceException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Out of range exception! I don't know what this actually means. Use a different envelope?", "ArgumentOutOfRangeException", MessageBoxButtons.OK, MessageBoxIcon.Question);
                //return;
            }

        }

        private void ListAddToActive_Click(object sender, EventArgs e)
        {
            try
            {
                formFieldsActive.Items.Add(formFieldsInactive.SelectedItem);
                formFieldsInactive.Items.Remove(formFieldsInactive.SelectedItem);
            }
            catch (Exception) { return; }
        }

        private void ListRemoveFromActive_Click(object sender, EventArgs e)
        {
            try
            {
                formFieldsInactive.Items.Add(formFieldsActive.SelectedItem);
                formFieldsActive.Items.Remove(formFieldsActive.SelectedItem);
            }
            catch (Exception) { return; }
        }

        public void AddActiveLabel(string newLabel)
        {
            if (!formFieldsActive.Items.Contains(newLabel))
            {
                formFieldsActive.Items.Add(newLabel);
            }
            if (formFieldsInactive.Items.Contains(newLabel))
            {
                formFieldsInactive.Items.Remove(newLabel);
            }
            customTabLabelText.Text = "";
        }
        private void AddCustomTabLabel_Click(object sender, EventArgs e)
        {
            AddActiveLabel(customTabLabelText.Text);
        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        public static string ToCsv(DataTable dataTable) //ripped from stackoverflow
        {
            StringBuilder sbData = new StringBuilder();

            // Only return Null if there is no structure.
            if (dataTable.Columns.Count == 0)
                return null;

            foreach (var col in dataTable.Columns)
            {
                if (col == null)
                    sbData.Append(",");
                else
                    sbData.Append("\"" + col.ToString().Replace("\"", "\"\"") + "\",");
            }

            sbData.Replace(",", System.Environment.NewLine, sbData.Length - 1, 1);

            foreach (DataRow dr in dataTable.Rows)
            {
                foreach (var column in dr.ItemArray)
                {
                    if (column == null)
                        sbData.Append(",");
                    else
                        sbData.Append("\"" + column.ToString().Replace("\"", "\"\"") + "\",");
                }
                sbData.Replace(",", System.Environment.NewLine, sbData.Length - 1, 1);
            }

            return sbData.ToString();
        }

        private void Test_Click(object sender, EventArgs eventArgs)
        {
            DataTable dataTable = new DataTable();
            dataTable.Clear();          
            dataTable.Columns.Add("Envelope Id",typeof(string));
            dataTable.Columns.Add("Subject", typeof(string));
            dataTable.Columns.Add("SentDate", typeof(string));
            if(infoToggleSender.Checked)
            {
                dataTable.Columns.Add("Sender Email");
            }
            if (InfoToggleSigner.Checked)
            {
                dataTable.Columns.Add("Signer Email");
            }
            foreach(string i in formFieldsActive.Items)
            {
                dataTable.Columns.Add(i, typeof(string));
            }
            DataColumnCollection columnCollection = dataTable.Columns;
            
            do
            {
                envelopeList = envelopesApi.ListStatusChanges(accountId, lcso);
                envelopes = envelopeList.Envelopes;
                progressBar1.Minimum = 1;
                progressBar1.Maximum = Int16.Parse(envelopeList.TotalSetSize);
                progressBar1.Step = 1;
                foreach (Envelope e in envelopes)
                {
                    progressBar1.PerformStep();
                    if (skipDrafts.Checked & String.IsNullOrEmpty(e.SentDateTime)) { continue; } //filters drafts
                    if (skipIncomplete.Checked & String.IsNullOrEmpty(e.CompletedDateTime)) { continue; } //filter completed 
                    DataRow row = dataTable.NewRow();
                    Recipients recipients = envelopesApi.ListRecipients(accountId, e.EnvelopeId, listRecipientsOptions);
                    try
                    {

                        row["Envelope Id"] = e.EnvelopeId;
                        row["Subject"] = e.EmailSubject;
                        row["SentDate"] = e.SentDateTime;
                        if (infoToggleSender.Checked) { row["Sender Email"] = e.Sender.Email; }
                        if (InfoToggleSigner.Checked) { row["Signer Email"] = e.Recipients.Signers[0].Email; }
                        try
                        {
                            foreach (Signer s in recipients.Signers)
                            {
                                foreach (Text t in s.Tabs.TextTabs)
                                {
                                    try
                                    {
                                        if (columnCollection.Contains(t.TabLabel))
                                        {
                                            row[t.TabLabel] = t.Value;
                                        }
                                    }
                                    catch (System.NullReferenceException) { }; //Not a concern - thrown when tag type isn't present
                                }

                                try
                                {
                                    foreach (List l in s.Tabs.ListTabs)
                                    {
                                        if (columnCollection.Contains(l.TabLabel))
                                        {
                                            row[l.TabLabel] = l.Value;
                                        }
                                    }
                                }
                                catch (System.NullReferenceException) { };

                                try
                                {
                                    foreach (Checkbox c in s.Tabs.CheckboxTabs)
                                    {
                                        if (columnCollection.Contains(c.TabLabel))
                                        {
                                            row[c.TabLabel] = c.Selected;
                                        }
                                    }
                                }
                                catch (System.NullReferenceException) { };

                                try
                                {
                                    foreach (FormulaTab f in s.Tabs.FormulaTabs)
                                    {
                                        if (columnCollection.Contains(f.TabLabel))
                                        {
                                            row[f.TabLabel] = f.Value;
                                        }
                                    }
                                }
                                catch (System.NullReferenceException) { }; //Not a concern - thrown when tag type isn't present
                            }
                        }
                        catch (System.NullReferenceException) { } //Not a concern - thrown when Signers aren't present
                    }
                    catch (System.ArgumentOutOfRangeException ex) { MessageBox.Show("Error: " + ex.Message, "ArgumentOutOfRange Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    catch (System.NullReferenceException) { }//MessageBox.Show("Error: " + ex.Message, "NullReference Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    catch (Exception ex) { MessageBox.Show("Error: " + ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error); continue; }
                    finally
                    {
                        System.Threading.Thread.Sleep(throttleSleepTime);
                    }
                    
                    dataTable.Rows.Add(row);
                }
                lcso.startPosition = Convert.ToString(Convert.ToInt16(envelopeList.EndPosition) + 1);
            } while (!String.IsNullOrEmpty(envelopeList.NextUri));

            var csvData = ToCsv(dataTable);
            
            try
            {
                File.WriteAllText(outPath.Text, csvData);
            } catch (System.IO.IOException)
            {
                MessageBox.Show("File write failed, appending to filename", "IO Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                try
                {
                    File.WriteAllText(outPath.Text + " (1).csv", csvData);
                }catch (System.IO.IOException ex)
                {
                    MessageBox.Show("File write failed again: " + ex.Message, "IO Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AppConfigSave_Click(object sender, EventArgs e)
        {
            if (buttonDemo.Checked)
            {
                configuration.AppSettings.Settings.Remove("DemoUser");
                configuration.AppSettings.Settings.Remove("DemoIkey");
                configuration.AppSettings.Settings.Remove("DemoKeypath");
                configuration.AppSettings.Settings.Add("DemoUser", userIdTextbox.Text);
                configuration.AppSettings.Settings.Add("DemoIkey", iKeyBox.Text);
                configuration.AppSettings.Settings.Add("DemoKeyPath", privateKeyBox.Text);
            }
            if (buttonProd.Checked)
            {
                configuration.AppSettings.Settings.Remove("ProdUser");
                configuration.AppSettings.Settings.Remove("ProdIkey");
                configuration.AppSettings.Settings.Remove("ProdKeypath");
                configuration.AppSettings.Settings.Add("ProdUser", userIdTextbox.Text);
                configuration.AppSettings.Settings.Add("ProdIkey", iKeyBox.Text);
                configuration.AppSettings.Settings.Add("ProdKeyPath", privateKeyBox.Text);
            }
            if (buttonStage.Checked)
            {
                configuration.AppSettings.Settings.Remove("StageUser");
                configuration.AppSettings.Settings.Remove("StageIkey");
                configuration.AppSettings.Settings.Remove("StageKeypath");
                configuration.AppSettings.Settings.Add("StageUser", userIdTextbox.Text);
                configuration.AppSettings.Settings.Add("StageIkey", iKeyBox.Text);
                configuration.AppSettings.Settings.Add("StageKeyPath", privateKeyBox.Text);
            }
            configuration.Save();
        }


        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
