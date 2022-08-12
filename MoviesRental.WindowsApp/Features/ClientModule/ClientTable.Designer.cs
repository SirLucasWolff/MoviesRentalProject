namespace MoviesRental.WindowsApp.Features.ClientModule
{
    partial class ClientTable
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
            this.DataGridClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClient)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridClient
            // 
            this.DataGridClient.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.DataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridClient.Location = new System.Drawing.Point(0, 0);
            this.DataGridClient.Name = "DataGridClient";
            this.DataGridClient.RowTemplate.Height = 25;
            this.DataGridClient.Size = new System.Drawing.Size(688, 643);
            this.DataGridClient.TabIndex = 0;
            // 
            // ClientTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridClient);
            this.Name = "ClientTable";
            this.Size = new System.Drawing.Size(688, 643);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataGridClient;
    }
}
