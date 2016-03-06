namespace SMTPHarness
{
    partial class SMTPTestHarness
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMTPTestHarness));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txbServer = new System.Windows.Forms.TextBox();
			this.txbPort = new System.Windows.Forms.TextBox();
			this.txbFrom = new System.Windows.Forms.TextBox();
			this.txbTo = new System.Windows.Forms.TextBox();
			this.txbSubject = new System.Windows.Forms.TextBox();
			this.txbBody = new System.Windows.Forms.TextBox();
			this.btSend = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.txbResult = new System.Windows.Forms.TextBox();
			this.cbxHtml = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txbUserName = new System.Windows.Forms.TextBox();
			this.txbPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(370, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Port";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "From Email";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 70);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "To Email";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Subject";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 122);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Body";
			// 
			// txbServer
			// 
			this.txbServer.Location = new System.Drawing.Point(76, 6);
			this.txbServer.Name = "txbServer";
			this.txbServer.Size = new System.Drawing.Size(275, 20);
			this.txbServer.TabIndex = 6;
			// 
			// txbPort
			// 
			this.txbPort.Location = new System.Drawing.Point(402, 6);
			this.txbPort.Name = "txbPort";
			this.txbPort.Size = new System.Drawing.Size(44, 20);
			this.txbPort.TabIndex = 7;
			this.txbPort.Text = "25";
			// 
			// txbFrom
			// 
			this.txbFrom.Location = new System.Drawing.Point(76, 38);
			this.txbFrom.Name = "txbFrom";
			this.txbFrom.Size = new System.Drawing.Size(275, 20);
			this.txbFrom.TabIndex = 8;
			// 
			// txbTo
			// 
			this.txbTo.Location = new System.Drawing.Point(76, 67);
			this.txbTo.Name = "txbTo";
			this.txbTo.Size = new System.Drawing.Size(275, 20);
			this.txbTo.TabIndex = 9;
			// 
			// txbSubject
			// 
			this.txbSubject.Location = new System.Drawing.Point(76, 93);
			this.txbSubject.Name = "txbSubject";
			this.txbSubject.Size = new System.Drawing.Size(275, 20);
			this.txbSubject.TabIndex = 10;
			// 
			// txbBody
			// 
			this.txbBody.Location = new System.Drawing.Point(76, 119);
			this.txbBody.Multiline = true;
			this.txbBody.Name = "txbBody";
			this.txbBody.Size = new System.Drawing.Size(410, 98);
			this.txbBody.TabIndex = 11;
			// 
			// btSend
			// 
			this.btSend.Location = new System.Drawing.Point(411, 261);
			this.btSend.Name = "btSend";
			this.btSend.Size = new System.Drawing.Size(75, 23);
			this.btSend.TabIndex = 12;
			this.btSend.Text = "Send";
			this.btSend.UseVisualStyleBackColor = true;
			this.btSend.Click += new System.EventHandler(this.btSend_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 307);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 13;
			this.label7.Text = "Result";
			// 
			// txbResult
			// 
			this.txbResult.Location = new System.Drawing.Point(76, 307);
			this.txbResult.Multiline = true;
			this.txbResult.Name = "txbResult";
			this.txbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txbResult.Size = new System.Drawing.Size(410, 224);
			this.txbResult.TabIndex = 14;
			// 
			// cbxHtml
			// 
			this.cbxHtml.AutoSize = true;
			this.cbxHtml.Location = new System.Drawing.Point(373, 96);
			this.cbxHtml.Name = "cbxHtml";
			this.cbxHtml.Size = new System.Drawing.Size(84, 17);
			this.cbxHtml.TabIndex = 15;
			this.cbxHtml.Text = "HTML Email";
			this.cbxHtml.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 235);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(57, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "UserName";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(252, 235);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 13);
			this.label9.TabIndex = 17;
			this.label9.Text = "Password";
			// 
			// txbUserName
			// 
			this.txbUserName.Location = new System.Drawing.Point(75, 232);
			this.txbUserName.Name = "txbUserName";
			this.txbUserName.Size = new System.Drawing.Size(171, 20);
			this.txbUserName.TabIndex = 18;
			// 
			// txbPassword
			// 
			this.txbPassword.Location = new System.Drawing.Point(311, 232);
			this.txbPassword.Name = "txbPassword";
			this.txbPassword.Size = new System.Drawing.Size(175, 20);
			this.txbPassword.TabIndex = 19;
			// 
			// SMTPTestHarness
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 545);
			this.Controls.Add(this.txbPassword);
			this.Controls.Add(this.txbUserName);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.cbxHtml);
			this.Controls.Add(this.txbResult);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btSend);
			this.Controls.Add(this.txbBody);
			this.Controls.Add(this.txbSubject);
			this.Controls.Add(this.txbTo);
			this.Controls.Add(this.txbFrom);
			this.Controls.Add(this.txbPort);
			this.Controls.Add(this.txbServer);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SMTPTestHarness";
			this.Text = "SMTP Test Harness";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.TextBox txbFrom;
        private System.Windows.Forms.TextBox txbTo;
        private System.Windows.Forms.TextBox txbSubject;
        private System.Windows.Forms.TextBox txbBody;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbResult;
		private System.Windows.Forms.CheckBox cbxHtml;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txbUserName;
		private System.Windows.Forms.TextBox txbPassword;
    }
}

