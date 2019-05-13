namespace Obtain2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userIdTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnvironmentPanel = new System.Windows.Forms.Panel();
            this.buttonProd = new System.Windows.Forms.RadioButton();
            this.buttonDemo = new System.Windows.Forms.RadioButton();
            this.buttonStage = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.iKeyBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAuth = new System.Windows.Forms.TabPage();
            this.appConfigSave = new System.Windows.Forms.Button();
            this.tabQuery = new System.Windows.Forms.TabPage();
            this.countButton = new System.Windows.Forms.Button();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toDateText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.fromDateText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabPage();
            this.infoToggleSender = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listRemoveFromActive = new System.Windows.Forms.Button();
            this.listAddToActive = new System.Windows.Forms.Button();
            this.formFieldsInactive = new System.Windows.Forms.ListBox();
            this.formFieldsActive = new System.Windows.Forms.ListBox();
            this.pullFormDataButton = new System.Windows.Forms.Button();
            this.exampleEnvelope = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addCustomTabLabel = new System.Windows.Forms.Button();
            this.customTabLabelText = new System.Windows.Forms.TextBox();
            this.InfoToggleSigner = new System.Windows.Forms.CheckBox();
            this.ExecuteQuery = new System.Windows.Forms.TabPage();
            this.skipIncomplete = new System.Windows.Forms.CheckBox();
            this.skipDrafts = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.processedCount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.outPath = new System.Windows.Forms.TextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.authStatusLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.EnvironmentPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabAuth.SuspendLayout();
            this.tabQuery.SuspendLayout();
            this.tabData.SuspendLayout();
            this.ExecuteQuery.SuspendLayout();
            this.SuspendLayout();
            // 
            // userIdTextbox
            // 
            this.userIdTextbox.Location = new System.Drawing.Point(6, 59);
            this.userIdTextbox.Name = "userIdTextbox";
            this.userIdTextbox.Size = new System.Drawing.Size(256, 20);
            this.userIdTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UserID";
            // 
            // EnvironmentPanel
            // 
            this.EnvironmentPanel.Controls.Add(this.buttonProd);
            this.EnvironmentPanel.Controls.Add(this.buttonDemo);
            this.EnvironmentPanel.Controls.Add(this.buttonStage);
            this.EnvironmentPanel.Location = new System.Drawing.Point(6, 6);
            this.EnvironmentPanel.Name = "EnvironmentPanel";
            this.EnvironmentPanel.Size = new System.Drawing.Size(186, 34);
            this.EnvironmentPanel.TabIndex = 3;
            // 
            // buttonProd
            // 
            this.buttonProd.AutoSize = true;
            this.buttonProd.Location = new System.Drawing.Point(62, 3);
            this.buttonProd.Name = "buttonProd";
            this.buttonProd.Size = new System.Drawing.Size(47, 17);
            this.buttonProd.TabIndex = 2;
            this.buttonProd.TabStop = true;
            this.buttonProd.Text = "Prod";
            this.buttonProd.UseVisualStyleBackColor = true;
            this.buttonProd.CheckedChanged += new System.EventHandler(this.buttonProd_CheckedChanged);
            // 
            // buttonDemo
            // 
            this.buttonDemo.AutoSize = true;
            this.buttonDemo.Location = new System.Drawing.Point(3, 3);
            this.buttonDemo.Name = "buttonDemo";
            this.buttonDemo.Size = new System.Drawing.Size(53, 17);
            this.buttonDemo.TabIndex = 1;
            this.buttonDemo.TabStop = true;
            this.buttonDemo.Text = "Demo";
            this.buttonDemo.UseVisualStyleBackColor = true;
            this.buttonDemo.CheckedChanged += new System.EventHandler(this.buttonDemo_CheckedChanged);
            // 
            // buttonStage
            // 
            this.buttonStage.AutoSize = true;
            this.buttonStage.Location = new System.Drawing.Point(115, 3);
            this.buttonStage.Name = "buttonStage";
            this.buttonStage.Size = new System.Drawing.Size(53, 17);
            this.buttonStage.TabIndex = 0;
            this.buttonStage.TabStop = true;
            this.buttonStage.Text = "Stage";
            this.buttonStage.UseVisualStyleBackColor = true;
            this.buttonStage.Visible = false;
            this.buttonStage.CheckedChanged += new System.EventHandler(this.buttonStage_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "iKey";
            // 
            // iKeyBox
            // 
            this.iKeyBox.Location = new System.Drawing.Point(6, 99);
            this.iKeyBox.Name = "iKeyBox";
            this.iKeyBox.Size = new System.Drawing.Size(256, 20);
            this.iKeyBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PrivateKeyFilename";
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(6, 143);
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.Size = new System.Drawing.Size(256, 20);
            this.privateKeyBox.TabIndex = 7;
            // 
            // authButton
            // 
            this.authButton.Location = new System.Drawing.Point(6, 169);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(75, 23);
            this.authButton.TabIndex = 8;
            this.authButton.Text = "Authorize";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Authorization Status:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAuth);
            this.tabControl1.Controls.Add(this.tabQuery);
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.ExecuteQuery);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 416);
            this.tabControl1.TabIndex = 11;
            // 
            // tabAuth
            // 
            this.tabAuth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabAuth.Controls.Add(this.appConfigSave);
            this.tabAuth.Controls.Add(this.EnvironmentPanel);
            this.tabAuth.Controls.Add(this.userIdTextbox);
            this.tabAuth.Controls.Add(this.label1);
            this.tabAuth.Controls.Add(this.authButton);
            this.tabAuth.Controls.Add(this.label2);
            this.tabAuth.Controls.Add(this.privateKeyBox);
            this.tabAuth.Controls.Add(this.iKeyBox);
            this.tabAuth.Controls.Add(this.label3);
            this.tabAuth.Location = new System.Drawing.Point(4, 22);
            this.tabAuth.Name = "tabAuth";
            this.tabAuth.Padding = new System.Windows.Forms.Padding(3);
            this.tabAuth.Size = new System.Drawing.Size(768, 390);
            this.tabAuth.TabIndex = 0;
            this.tabAuth.Text = "AuthInfo";
            // 
            // appConfigSave
            // 
            this.appConfigSave.Location = new System.Drawing.Point(6, 334);
            this.appConfigSave.Name = "appConfigSave";
            this.appConfigSave.Size = new System.Drawing.Size(75, 36);
            this.appConfigSave.TabIndex = 9;
            this.appConfigSave.Text = "Save to AppConfig";
            this.appConfigSave.UseVisualStyleBackColor = true;
            this.appConfigSave.Click += new System.EventHandler(this.AppConfigSave_Click);
            // 
            // tabQuery
            // 
            this.tabQuery.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabQuery.Controls.Add(this.countButton);
            this.tabQuery.Controls.Add(this.subjectText);
            this.tabQuery.Controls.Add(this.label8);
            this.tabQuery.Controls.Add(this.toDateText);
            this.tabQuery.Controls.Add(this.label7);
            this.tabQuery.Controls.Add(this.fromDateText);
            this.tabQuery.Controls.Add(this.label6);
            this.tabQuery.Location = new System.Drawing.Point(4, 22);
            this.tabQuery.Name = "tabQuery";
            this.tabQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabQuery.Size = new System.Drawing.Size(768, 390);
            this.tabQuery.TabIndex = 1;
            this.tabQuery.Text = "QueryInfo";
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(180, 77);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(100, 23);
            this.countButton.TabIndex = 10;
            this.countButton.Text = "Count Envelopes";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(10, 77);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(153, 20);
            this.subjectText.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Subject";
            // 
            // toDateText
            // 
            this.toDateText.Location = new System.Drawing.Point(180, 23);
            this.toDateText.Name = "toDateText";
            this.toDateText.Size = new System.Drawing.Size(100, 20);
            this.toDateText.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "toDateTime";
            // 
            // fromDateText
            // 
            this.fromDateText.Location = new System.Drawing.Point(10, 24);
            this.fromDateText.Name = "fromDateText";
            this.fromDateText.Size = new System.Drawing.Size(119, 20);
            this.fromDateText.TabIndex = 5;
            this.fromDateText.Text = "2015-10-01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "fromDateTime (YYYY-MM-DD)";
            // 
            // tabData
            // 
            this.tabData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabData.Controls.Add(this.infoToggleSender);
            this.tabData.Controls.Add(this.label12);
            this.tabData.Controls.Add(this.label11);
            this.tabData.Controls.Add(this.listRemoveFromActive);
            this.tabData.Controls.Add(this.listAddToActive);
            this.tabData.Controls.Add(this.formFieldsInactive);
            this.tabData.Controls.Add(this.formFieldsActive);
            this.tabData.Controls.Add(this.pullFormDataButton);
            this.tabData.Controls.Add(this.exampleEnvelope);
            this.tabData.Controls.Add(this.label10);
            this.tabData.Controls.Add(this.label5);
            this.tabData.Controls.Add(this.addCustomTabLabel);
            this.tabData.Controls.Add(this.customTabLabelText);
            this.tabData.Controls.Add(this.InfoToggleSigner);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(768, 390);
            this.tabData.TabIndex = 2;
            this.tabData.Text = "FormData";
            // 
            // infoToggleSender
            // 
            this.infoToggleSender.AutoSize = true;
            this.infoToggleSender.Location = new System.Drawing.Point(10, 105);
            this.infoToggleSender.Name = "infoToggleSender";
            this.infoToggleSender.Size = new System.Drawing.Size(118, 17);
            this.infoToggleSender.TabIndex = 17;
            this.infoToggleSender.Text = "Record Sender info";
            this.infoToggleSender.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Active Fields";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(338, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Available Fields";
            // 
            // listRemoveFromActive
            // 
            this.listRemoveFromActive.Location = new System.Drawing.Point(475, 126);
            this.listRemoveFromActive.Name = "listRemoveFromActive";
            this.listRemoveFromActive.Size = new System.Drawing.Size(41, 37);
            this.listRemoveFromActive.TabIndex = 14;
            this.listRemoveFromActive.Text = "<=";
            this.listRemoveFromActive.UseVisualStyleBackColor = true;
            this.listRemoveFromActive.Click += new System.EventHandler(this.ListRemoveFromActive_Click);
            // 
            // listAddToActive
            // 
            this.listAddToActive.Location = new System.Drawing.Point(476, 64);
            this.listAddToActive.Name = "listAddToActive";
            this.listAddToActive.Size = new System.Drawing.Size(41, 37);
            this.listAddToActive.TabIndex = 13;
            this.listAddToActive.Text = "=>";
            this.listAddToActive.UseVisualStyleBackColor = true;
            this.listAddToActive.Click += new System.EventHandler(this.ListAddToActive_Click);
            // 
            // formFieldsInactive
            // 
            this.formFieldsInactive.FormattingEnabled = true;
            this.formFieldsInactive.Location = new System.Drawing.Point(338, 39);
            this.formFieldsInactive.Name = "formFieldsInactive";
            this.formFieldsInactive.Size = new System.Drawing.Size(131, 199);
            this.formFieldsInactive.TabIndex = 12;
            // 
            // formFieldsActive
            // 
            this.formFieldsActive.FormattingEnabled = true;
            this.formFieldsActive.Location = new System.Drawing.Point(523, 39);
            this.formFieldsActive.Name = "formFieldsActive";
            this.formFieldsActive.Size = new System.Drawing.Size(131, 199);
            this.formFieldsActive.TabIndex = 11;
            // 
            // pullFormDataButton
            // 
            this.pullFormDataButton.Location = new System.Drawing.Point(10, 65);
            this.pullFormDataButton.Name = "pullFormDataButton";
            this.pullFormDataButton.Size = new System.Drawing.Size(98, 23);
            this.pullFormDataButton.TabIndex = 10;
            this.pullFormDataButton.Text = "Pull Data Labels";
            this.pullFormDataButton.UseVisualStyleBackColor = true;
            this.pullFormDataButton.Click += new System.EventHandler(this.PullFormDataButton_Click);
            // 
            // exampleEnvelope
            // 
            this.exampleEnvelope.Location = new System.Drawing.Point(10, 39);
            this.exampleEnvelope.Name = "exampleEnvelope";
            this.exampleEnvelope.Size = new System.Drawing.Size(198, 20);
            this.exampleEnvelope.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Pull Form Data from Envelope: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Custom TabLabel";
            // 
            // addCustomTabLabel
            // 
            this.addCustomTabLabel.Location = new System.Drawing.Point(4, 215);
            this.addCustomTabLabel.Name = "addCustomTabLabel";
            this.addCustomTabLabel.Size = new System.Drawing.Size(104, 23);
            this.addCustomTabLabel.TabIndex = 6;
            this.addCustomTabLabel.Text = "Add TabLabel";
            this.addCustomTabLabel.UseVisualStyleBackColor = true;
            this.addCustomTabLabel.Click += new System.EventHandler(this.AddCustomTabLabel_Click);
            // 
            // customTabLabelText
            // 
            this.customTabLabelText.Location = new System.Drawing.Point(4, 188);
            this.customTabLabelText.Name = "customTabLabelText";
            this.customTabLabelText.Size = new System.Drawing.Size(125, 20);
            this.customTabLabelText.TabIndex = 5;
            // 
            // InfoToggleSigner
            // 
            this.InfoToggleSigner.AutoSize = true;
            this.InfoToggleSigner.Location = new System.Drawing.Point(10, 137);
            this.InfoToggleSigner.Name = "InfoToggleSigner";
            this.InfoToggleSigner.Size = new System.Drawing.Size(123, 17);
            this.InfoToggleSigner.TabIndex = 4;
            this.InfoToggleSigner.Text = "Record Signer 1 info";
            this.InfoToggleSigner.UseVisualStyleBackColor = true;
            // 
            // ExecuteQuery
            // 
            this.ExecuteQuery.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ExecuteQuery.Controls.Add(this.skipIncomplete);
            this.ExecuteQuery.Controls.Add(this.skipDrafts);
            this.ExecuteQuery.Controls.Add(this.progressBar1);
            this.ExecuteQuery.Controls.Add(this.processedCount);
            this.ExecuteQuery.Controls.Add(this.label14);
            this.ExecuteQuery.Controls.Add(this.label13);
            this.ExecuteQuery.Controls.Add(this.outPath);
            this.ExecuteQuery.Controls.Add(this.Execute);
            this.ExecuteQuery.Location = new System.Drawing.Point(4, 22);
            this.ExecuteQuery.Name = "ExecuteQuery";
            this.ExecuteQuery.Padding = new System.Windows.Forms.Padding(3);
            this.ExecuteQuery.Size = new System.Drawing.Size(768, 390);
            this.ExecuteQuery.TabIndex = 3;
            this.ExecuteQuery.Text = "ExecuteQuery";
            // 
            // skipIncomplete
            // 
            this.skipIncomplete.AutoSize = true;
            this.skipIncomplete.Checked = true;
            this.skipIncomplete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skipIncomplete.Location = new System.Drawing.Point(591, 50);
            this.skipIncomplete.Name = "skipIncomplete";
            this.skipIncomplete.Size = new System.Drawing.Size(102, 17);
            this.skipIncomplete.TabIndex = 7;
            this.skipIncomplete.Text = "Skip Incomplete";
            this.skipIncomplete.UseVisualStyleBackColor = true;
            // 
            // skipDrafts
            // 
            this.skipDrafts.AutoSize = true;
            this.skipDrafts.Checked = true;
            this.skipDrafts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skipDrafts.Location = new System.Drawing.Point(591, 26);
            this.skipDrafts.Name = "skipDrafts";
            this.skipDrafts.Size = new System.Drawing.Size(78, 17);
            this.skipDrafts.TabIndex = 6;
            this.skipDrafts.Text = "Skip Drafts";
            this.skipDrafts.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(180, 322);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(392, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // processedCount
            // 
            this.processedCount.AutoSize = true;
            this.processedCount.Location = new System.Drawing.Point(85, 279);
            this.processedCount.Name = "processedCount";
            this.processedCount.Size = new System.Drawing.Size(0, 13);
            this.processedCount.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 279);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Processed: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "outPath";
            // 
            // outPath
            // 
            this.outPath.Location = new System.Drawing.Point(27, 71);
            this.outPath.Name = "outPath";
            this.outPath.Size = new System.Drawing.Size(383, 20);
            this.outPath.TabIndex = 1;
            // 
            // Execute
            // 
            this.Execute.Location = new System.Drawing.Point(339, 168);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(71, 57);
            this.Execute.TabIndex = 0;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Test_Click);
            // 
            // authStatusLabel
            // 
            this.authStatusLabel.AutoSize = true;
            this.authStatusLabel.Location = new System.Drawing.Point(117, 9);
            this.authStatusLabel.Name = "authStatusLabel";
            this.authStatusLabel.Size = new System.Drawing.Size(53, 13);
            this.authStatusLabel.TabIndex = 12;
            this.authStatusLabel.Text = "Unknown";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Envelopes Found: ";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(286, 9);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(25, 13);
            this.countLabel.TabIndex = 12;
            this.countLabel.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.authStatusLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Obtain2";
            this.EnvironmentPanel.ResumeLayout(false);
            this.EnvironmentPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabAuth.ResumeLayout(false);
            this.tabAuth.PerformLayout();
            this.tabQuery.ResumeLayout(false);
            this.tabQuery.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.tabData.PerformLayout();
            this.ExecuteQuery.ResumeLayout(false);
            this.ExecuteQuery.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel EnvironmentPanel;
        private System.Windows.Forms.RadioButton buttonProd;
        private System.Windows.Forms.RadioButton buttonDemo;
        private System.Windows.Forms.RadioButton buttonStage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iKeyBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAuth;
        private System.Windows.Forms.TabPage tabQuery;
        private System.Windows.Forms.Label authStatusLabel;
        private System.Windows.Forms.TextBox toDateText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fromDateText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.Button pullFormDataButton;
        private System.Windows.Forms.TextBox exampleEnvelope;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addCustomTabLabel;
        private System.Windows.Forms.TextBox customTabLabelText;
        private System.Windows.Forms.CheckBox InfoToggleSigner;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.ListBox formFieldsActive;
        private System.Windows.Forms.ListBox formFieldsInactive;
        private System.Windows.Forms.Button listRemoveFromActive;
        private System.Windows.Forms.Button listAddToActive;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage ExecuteQuery;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.CheckBox infoToggleSender;
        private System.Windows.Forms.TextBox outPath;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label processedCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox skipDrafts;
        private System.Windows.Forms.CheckBox skipIncomplete;
        private System.Windows.Forms.Button appConfigSave;
    }
}

