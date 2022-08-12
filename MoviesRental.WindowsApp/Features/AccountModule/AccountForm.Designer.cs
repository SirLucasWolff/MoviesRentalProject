namespace MoviesRental.WindowsApp.Features.AccountModule
{
    partial class AccountForm
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
            this.ScreensPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ScreensPanel
            // 
            this.ScreensPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ScreensPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreensPanel.Location = new System.Drawing.Point(0, 0);
            this.ScreensPanel.Name = "ScreensPanel";
            this.ScreensPanel.Size = new System.Drawing.Size(419, 299);
            this.ScreensPanel.TabIndex = 0;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(419, 299);
            this.Controls.Add(this.ScreensPanel);
            this.Name = "AccountForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ScreensPanel;
    }
}