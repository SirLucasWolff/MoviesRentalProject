namespace MoviesRental.WindowsApp.Features.AccountModule
{
    partial class Dashboard
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
            this.label9 = new System.Windows.Forms.Label();
            this.ActiveRentsLabel = new System.Windows.Forms.Label();
            this.PendingRentsLabel = new System.Windows.Forms.Label();
            this.ExpiredRentsLabel = new System.Windows.Forms.Label();
            this.ActiveRentsQuantity = new System.Windows.Forms.Label();
            this.PendingRentsQuantity = new System.Windows.Forms.Label();
            this.ExpiredRentsQuantity = new System.Windows.Forms.Label();
            this.DashboardRefreshButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(795, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Dashboard";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(772, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // ActiveRentsLabel
            // 
            this.ActiveRentsLabel.AutoSize = true;
            this.ActiveRentsLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveRentsLabel.Location = new System.Drawing.Point(577, 156);
            this.ActiveRentsLabel.Name = "ActiveRentsLabel";
            this.ActiveRentsLabel.Size = new System.Drawing.Size(81, 18);
            this.ActiveRentsLabel.TabIndex = 48;
            this.ActiveRentsLabel.Text = "Active rents";
            // 
            // PendingRentsLabel
            // 
            this.PendingRentsLabel.AutoSize = true;
            this.PendingRentsLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PendingRentsLabel.Location = new System.Drawing.Point(803, 156);
            this.PendingRentsLabel.Name = "PendingRentsLabel";
            this.PendingRentsLabel.Size = new System.Drawing.Size(94, 18);
            this.PendingRentsLabel.TabIndex = 49;
            this.PendingRentsLabel.Text = "Pending rents";
            // 
            // ExpiredRentsLabel
            // 
            this.ExpiredRentsLabel.AutoSize = true;
            this.ExpiredRentsLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpiredRentsLabel.Location = new System.Drawing.Point(1046, 156);
            this.ExpiredRentsLabel.Name = "ExpiredRentsLabel";
            this.ExpiredRentsLabel.Size = new System.Drawing.Size(90, 18);
            this.ExpiredRentsLabel.TabIndex = 50;
            this.ExpiredRentsLabel.Text = "Expired rents";
            // 
            // ActiveRentsQuantity
            // 
            this.ActiveRentsQuantity.AutoSize = true;
            this.ActiveRentsQuantity.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveRentsQuantity.Location = new System.Drawing.Point(585, 88);
            this.ActiveRentsQuantity.Name = "ActiveRentsQuantity";
            this.ActiveRentsQuantity.Size = new System.Drawing.Size(73, 59);
            this.ActiveRentsQuantity.TabIndex = 51;
            this.ActiveRentsQuantity.Text = "10";
            // 
            // PendingRentsQuantity
            // 
            this.PendingRentsQuantity.AutoSize = true;
            this.PendingRentsQuantity.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PendingRentsQuantity.Location = new System.Drawing.Point(814, 88);
            this.PendingRentsQuantity.Name = "PendingRentsQuantity";
            this.PendingRentsQuantity.Size = new System.Drawing.Size(73, 59);
            this.PendingRentsQuantity.TabIndex = 52;
            this.PendingRentsQuantity.Text = "10";
            // 
            // ExpiredRentsQuantity
            // 
            this.ExpiredRentsQuantity.AutoSize = true;
            this.ExpiredRentsQuantity.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpiredRentsQuantity.Location = new System.Drawing.Point(1063, 88);
            this.ExpiredRentsQuantity.Name = "ExpiredRentsQuantity";
            this.ExpiredRentsQuantity.Size = new System.Drawing.Size(73, 59);
            this.ExpiredRentsQuantity.TabIndex = 53;
            this.ExpiredRentsQuantity.Text = "10";
            // 
            // DashboardRefreshButton
            // 
            this.DashboardRefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardRefreshButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DashboardRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardRefreshButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DashboardRefreshButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Refresh_icon_black_edition;
            this.DashboardRefreshButton.Location = new System.Drawing.Point(1736, 3);
            this.DashboardRefreshButton.Name = "DashboardRefreshButton";
            this.DashboardRefreshButton.Size = new System.Drawing.Size(71, 39);
            this.DashboardRefreshButton.TabIndex = 54;
            this.DashboardRefreshButton.UseVisualStyleBackColor = false;
            this.DashboardRefreshButton.Click += new System.EventHandler(this.DashboardRefreshButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.DashboardRefreshButton);
            this.Controls.Add(this.ExpiredRentsQuantity);
            this.Controls.Add(this.PendingRentsQuantity);
            this.Controls.Add(this.ActiveRentsQuantity);
            this.Controls.Add(this.ExpiredRentsLabel);
            this.Controls.Add(this.PendingRentsLabel);
            this.Controls.Add(this.ActiveRentsLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(1837, 196);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label9;
        private Label ActiveRentsLabel;
        private Label PendingRentsLabel;
        private Label ExpiredRentsLabel;
        private Label ActiveRentsQuantity;
        private Label PendingRentsQuantity;
        private Label ExpiredRentsQuantity;
        private Button DashboardRefreshButton;
    }
}
