﻿namespace MoviesRental.WindowsApp.Features.SettingsModule
{
    partial class FrameworkSettingsForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.SQLServerRB = new System.Windows.Forms.RadioButton();
            this.EntityFrameworkRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(102, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 33);
            this.label3.TabIndex = 27;
            this.label3.Text = "Framework settings";
            // 
            // SQLServerRB
            // 
            this.SQLServerRB.AutoSize = true;
            this.SQLServerRB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SQLServerRB.Location = new System.Drawing.Point(102, 70);
            this.SQLServerRB.Name = "SQLServerRB";
            this.SQLServerRB.Size = new System.Drawing.Size(89, 22);
            this.SQLServerRB.TabIndex = 52;
            this.SQLServerRB.TabStop = true;
            this.SQLServerRB.Text = "SQLServer";
            this.SQLServerRB.UseVisualStyleBackColor = true;
            this.SQLServerRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SQLServerRB_MouseClick);
            // 
            // EntityFrameworkRB
            // 
            this.EntityFrameworkRB.AutoSize = true;
            this.EntityFrameworkRB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EntityFrameworkRB.Location = new System.Drawing.Point(214, 70);
            this.EntityFrameworkRB.Name = "EntityFrameworkRB";
            this.EntityFrameworkRB.Size = new System.Drawing.Size(134, 22);
            this.EntityFrameworkRB.TabIndex = 51;
            this.EntityFrameworkRB.TabStop = true;
            this.EntityFrameworkRB.Text = "Entity Framework";
            this.EntityFrameworkRB.UseVisualStyleBackColor = true;
            this.EntityFrameworkRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EntityFrameworkRB_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "When the framework is changed the application will be restarted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(397, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "______________________________________________________________________________";
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.SlateBlue;
            this.EnterButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterButton.Location = new System.Drawing.Point(178, 175);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(103, 38);
            this.EnterButton.TabIndex = 55;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // FrameworkSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 227);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SQLServerRB);
            this.Controls.Add(this.EntityFrameworkRB);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrameworkSettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrameworkSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private RadioButton SQLServerRB;
        private RadioButton EntityFrameworkRB;
        private Label label1;
        private Label label2;
        private Button EnterButton;
    }
}