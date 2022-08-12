namespace MoviesRental.WindowsApp.Features.EmployeeModule
{
    partial class EmployeeForm
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
            this.EnterButton = new System.Windows.Forms.Button();
            this.TextTelephone = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EnterButtonEmployee = new System.Windows.Forms.Button();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextEmployeeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.EmployeeStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.SlateBlue;
            this.EnterButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterButton.Location = new System.Drawing.Point(151, 146);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(103, 38);
            this.EnterButton.TabIndex = 14;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            // 
            // TextTelephone
            // 
            this.TextTelephone.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextTelephone.Location = new System.Drawing.Point(113, 83);
            this.TextTelephone.Name = "TextTelephone";
            this.TextTelephone.Size = new System.Drawing.Size(258, 27);
            this.TextTelephone.TabIndex = 13;
            // 
            // TextName
            // 
            this.TextName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextName.Location = new System.Drawing.Point(113, 50);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(258, 27);
            this.TextName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(29, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // EnterButtonEmployee
            // 
            this.EnterButtonEmployee.BackColor = System.Drawing.Color.SlateBlue;
            this.EnterButtonEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterButtonEmployee.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterButtonEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterButtonEmployee.Location = new System.Drawing.Point(162, 181);
            this.EnterButtonEmployee.Name = "EnterButtonEmployee";
            this.EnterButtonEmployee.Size = new System.Drawing.Size(103, 38);
            this.EnterButtonEmployee.TabIndex = 14;
            this.EnterButtonEmployee.Text = "Enter";
            this.EnterButtonEmployee.UseVisualStyleBackColor = false;
            this.EnterButtonEmployee.Click += new System.EventHandler(this.EnterButtonEmployee_Click);
            // 
            // TextPassword
            // 
            this.TextPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextPassword.Location = new System.Drawing.Point(110, 125);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.PasswordChar = '*';
            this.TextPassword.Size = new System.Drawing.Size(258, 26);
            this.TextPassword.TabIndex = 13;
            this.TextPassword.Leave += new System.EventHandler(this.TextPassword_Leave);
            // 
            // TextEmployeeName
            // 
            this.TextEmployeeName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextEmployeeName.Location = new System.Drawing.Point(110, 92);
            this.TextEmployeeName.Name = "TextEmployeeName";
            this.TextEmployeeName.Size = new System.Drawing.Size(258, 26);
            this.TextEmployeeName.TabIndex = 12;
            this.TextEmployeeName.Leave += new System.EventHandler(this.TextEmployeeName_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(34, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(55, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 231);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(435, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // EmployeeStatusText
            // 
            this.EmployeeStatusText.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeStatusText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EmployeeStatusText.Name = "EmployeeStatusText";
            this.EmployeeStatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(127, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Employee form";
            // 
            // TextEmail
            // 
            this.TextEmail.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextEmail.Location = new System.Drawing.Point(110, 60);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(258, 26);
            this.TextEmail.TabIndex = 18;
            this.TextEmail.Leave += new System.EventHandler(this.TextEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(59, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email:";
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Show_password_button;
            this.ShowPasswordButton.Location = new System.Drawing.Point(374, 128);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(29, 23);
            this.ShowPasswordButton.TabIndex = 19;
            this.ShowPasswordButton.UseVisualStyleBackColor = true;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // EmployeeForm
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(435, 253);
            this.Controls.Add(this.ShowPasswordButton);
            this.Controls.Add(this.TextEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EnterButtonEmployee);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextEmployeeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "EmployeeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EnterButton;
        private TextBox TextTelephone;
        private TextBox TextName;
        private Label label2;
        private Label label1;
        private Button EnterButtonEmployee;
        private TextBox TextPassword;
        private TextBox TextEmployeeName;
        private Label label5;
        private Label label6;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel EmployeeStatusText;
        private Label label3;
        private TextBox TextEmail;
        private Label label4;
        private Button ShowPasswordButton;
    }
}