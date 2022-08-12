namespace MoviesRental.WindowsApp.Features.EmployeeModule
{
    partial class EmployeeTable
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
            this.DataGridEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridEmployee
            // 
            this.DataGridEmployee.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.DataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridEmployee.Location = new System.Drawing.Point(0, 0);
            this.DataGridEmployee.Name = "DataGridEmployee";
            this.DataGridEmployee.RowTemplate.Height = 25;
            this.DataGridEmployee.Size = new System.Drawing.Size(700, 659);
            this.DataGridEmployee.TabIndex = 0;
            // 
            // EmployeeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridEmployee);
            this.Name = "EmployeeTable";
            this.Size = new System.Drawing.Size(700, 659);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DataGridEmployee;
    }
}
