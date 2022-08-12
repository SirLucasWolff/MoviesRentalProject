namespace MoviesRental.WindowsApp.Features.EmployeeModule
{
    partial class AccessForm
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
            this.EnterButtonEmployee = new System.Windows.Forms.Button();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.TextEmployeeName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterButtonEmployee
            // 
            this.EnterButtonEmployee.BackColor = System.Drawing.Color.SlateBlue;
            this.EnterButtonEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterButtonEmployee.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterButtonEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterButtonEmployee.Location = new System.Drawing.Point(148, 127);
            this.EnterButtonEmployee.Name = "EnterButtonEmployee";
            this.EnterButtonEmployee.Size = new System.Drawing.Size(103, 38);
            this.EnterButtonEmployee.TabIndex = 19;
            this.EnterButtonEmployee.Text = "Enter";
            this.EnterButtonEmployee.UseVisualStyleBackColor = false;
            // 
            // TextPassword
            // 
            this.TextPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextPassword.Location = new System.Drawing.Point(104, 67);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(258, 26);
            this.TextPassword.TabIndex = 18;
            // 
            // TextEmployeeName
            // 
            this.TextEmployeeName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextEmployeeName.Location = new System.Drawing.Point(104, 34);
            this.TextEmployeeName.Name = "TextEmployeeName";
            this.TextEmployeeName.Size = new System.Drawing.Size(258, 26);
            this.TextEmployeeName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(28, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(49, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name:";
            // 
            // AccessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 178);
            this.Controls.Add(this.EnterButtonEmployee);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.TextEmployeeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "AccessForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EnterButtonEmployee;
        private TextBox TextPassword;
        private TextBox TextEmployeeName;
        private Label label5;
        private Label label6;
    }
}