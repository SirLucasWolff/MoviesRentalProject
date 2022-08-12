namespace MoviesRental.WindowsApp.Features.RentModule
{
    partial class FilterRentForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.ActiveRentsRD = new System.Windows.Forms.RadioButton();
            this.RentsNearReturnRB = new System.Windows.Forms.RadioButton();
            this.PendingRentsRB = new System.Windows.Forms.RadioButton();
            this.OkButtonRent = new System.Windows.Forms.Button();
            this.ShowAllRentsRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(196, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 33);
            this.label5.TabIndex = 45;
            this.label5.Text = "Filter rents";
            // 
            // ActiveRentsRD
            // 
            this.ActiveRentsRD.AutoSize = true;
            this.ActiveRentsRD.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveRentsRD.Location = new System.Drawing.Point(121, 65);
            this.ActiveRentsRD.Name = "ActiveRentsRD";
            this.ActiveRentsRD.Size = new System.Drawing.Size(99, 22);
            this.ActiveRentsRD.TabIndex = 46;
            this.ActiveRentsRD.TabStop = true;
            this.ActiveRentsRD.Text = "Active rents";
            this.ActiveRentsRD.UseVisualStyleBackColor = true;
            this.ActiveRentsRD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ActiveRentsRD_MouseClick);
            // 
            // RentsNearReturnRB
            // 
            this.RentsNearReturnRB.AutoSize = true;
            this.RentsNearReturnRB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentsNearReturnRB.Location = new System.Drawing.Point(238, 65);
            this.RentsNearReturnRB.Name = "RentsNearReturnRB";
            this.RentsNearReturnRB.Size = new System.Drawing.Size(134, 22);
            this.RentsNearReturnRB.TabIndex = 47;
            this.RentsNearReturnRB.TabStop = true;
            this.RentsNearReturnRB.Text = "Rents near return";
            this.RentsNearReturnRB.UseVisualStyleBackColor = true;
            this.RentsNearReturnRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RentsNearReturnRB_MouseClick);
            // 
            // PendingRentsRB
            // 
            this.PendingRentsRB.AutoSize = true;
            this.PendingRentsRB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PendingRentsRB.Location = new System.Drawing.Point(387, 65);
            this.PendingRentsRB.Name = "PendingRentsRB";
            this.PendingRentsRB.Size = new System.Drawing.Size(112, 22);
            this.PendingRentsRB.TabIndex = 48;
            this.PendingRentsRB.TabStop = true;
            this.PendingRentsRB.Text = "Pending rents";
            this.PendingRentsRB.UseVisualStyleBackColor = true;
            this.PendingRentsRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PendingRentsRB_MouseClick);
            // 
            // OkButtonRent
            // 
            this.OkButtonRent.BackColor = System.Drawing.Color.SlateBlue;
            this.OkButtonRent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButtonRent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OkButtonRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OkButtonRent.Location = new System.Drawing.Point(213, 122);
            this.OkButtonRent.Name = "OkButtonRent";
            this.OkButtonRent.Size = new System.Drawing.Size(103, 38);
            this.OkButtonRent.TabIndex = 49;
            this.OkButtonRent.Text = "Ok";
            this.OkButtonRent.UseVisualStyleBackColor = false;
            // 
            // ShowAllRentsRB
            // 
            this.ShowAllRentsRB.AutoSize = true;
            this.ShowAllRentsRB.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAllRentsRB.Location = new System.Drawing.Point(28, 65);
            this.ShowAllRentsRB.Name = "ShowAllRentsRB";
            this.ShowAllRentsRB.Size = new System.Drawing.Size(78, 22);
            this.ShowAllRentsRB.TabIndex = 50;
            this.ShowAllRentsRB.TabStop = true;
            this.ShowAllRentsRB.Text = "Show all";
            this.ShowAllRentsRB.UseVisualStyleBackColor = true;
            this.ShowAllRentsRB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowAllRentsRB_MouseClick);
            // 
            // FilterRentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 172);
            this.Controls.Add(this.ShowAllRentsRB);
            this.Controls.Add(this.OkButtonRent);
            this.Controls.Add(this.PendingRentsRB);
            this.Controls.Add(this.RentsNearReturnRB);
            this.Controls.Add(this.ActiveRentsRD);
            this.Controls.Add(this.label5);
            this.Name = "FilterRentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private RadioButton ActiveRentsRD;
        private RadioButton RentsNearReturnRB;
        private RadioButton PendingRentsRB;
        private Button OkButtonRent;
        private RadioButton ShowAllRentsRB;
    }
}