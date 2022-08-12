namespace MoviesRental.WindowsApp.Features.MovieModule
{
    partial class MovieTable
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
            this.DataGridMovie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridMovie
            // 
            this.DataGridMovie.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.DataGridMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridMovie.Location = new System.Drawing.Point(0, 0);
            this.DataGridMovie.Name = "DataGridMovie";
            this.DataGridMovie.RowTemplate.Height = 25;
            this.DataGridMovie.Size = new System.Drawing.Size(738, 686);
            this.DataGridMovie.TabIndex = 0;
            // 
            // MovieTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridMovie);
            this.Name = "MovieTable";
            this.Size = new System.Drawing.Size(738, 686);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMovie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataGridMovie;
    }
}
