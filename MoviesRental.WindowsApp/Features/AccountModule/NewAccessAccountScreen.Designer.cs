namespace MoviesRental.WindowsApp.Features.AccountModule
{
    partial class NewAccessAccountScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ForgottenPasswordLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.AccessKeyText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AccessStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Access with your account";
            // 
            // TextPassword
            // 
            this.TextPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextPassword.Location = new System.Drawing.Point(122, 115);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(258, 26);
            this.TextPassword.TabIndex = 7;
            this.TextPassword.Leave += new System.EventHandler(this.TextPassword_Leave);
            // 
            // TextEmail
            // 
            this.TextEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextEmail.Location = new System.Drawing.Point(122, 82);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(258, 26);
            this.TextEmail.TabIndex = 6;
            this.TextEmail.Leave += new System.EventHandler(this.TextEmail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(67, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // ForgottenPasswordLink
            // 
            this.ForgottenPasswordLink.AutoSize = true;
            this.ForgottenPasswordLink.LinkColor = System.Drawing.Color.Black;
            this.ForgottenPasswordLink.Location = new System.Drawing.Point(122, 144);
            this.ForgottenPasswordLink.Name = "ForgottenPasswordLink";
            this.ForgottenPasswordLink.Size = new System.Drawing.Size(115, 15);
            this.ForgottenPasswordLink.TabIndex = 8;
            this.ForgottenPasswordLink.TabStop = true;
            this.ForgottenPasswordLink.Text = "Forgot my password";
            this.ForgottenPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgottenPasswordLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(397, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "______________________________________________________________________________";
            // 
            // AccessKeyText
            // 
            this.AccessKeyText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessKeyText.Location = new System.Drawing.Point(122, 186);
            this.AccessKeyText.Name = "AccessKeyText";
            this.AccessKeyText.Size = new System.Drawing.Size(258, 26);
            this.AccessKeyText.TabIndex = 11;
            this.AccessKeyText.Leave += new System.EventHandler(this.AccessKeyText_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(31, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Access key:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccessStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 279);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(421, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AccessStatus
            // 
            this.AccessStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccessStatus.Name = "AccessStatus";
            this.AccessStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.SlateBlue;
            this.EnterButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterButton.Location = new System.Drawing.Point(160, 231);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(103, 38);
            this.EnterButton.TabIndex = 13;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // NewAccessAccountScreen
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.AccessKeyText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ForgottenPasswordLink);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "NewAccessAccountScreen";
            this.Size = new System.Drawing.Size(421, 301);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TextPassword;
        private TextBox TextEmail;
        private Label label2;
        private Label label3;
        private LinkLabel ForgottenPasswordLink;
        private Label label4;
        private TextBox AccessKeyText;
        private Label label5;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel AccessStatus;
        private Button EnterButton;
    }
}
