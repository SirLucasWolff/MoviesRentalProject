namespace MoviesRental.WindowsApp.Features.RentModule
{
    partial class RentForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovieValueSymbol = new System.Windows.Forms.Label();
            this.DayValueSymbol = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TotalPriceSymbol = new System.Windows.Forms.Label();
            this.TotalValueSymbol = new System.Windows.Forms.Label();
            this.TotalValue = new System.Windows.Forms.Label();
            this.TotalValueText = new System.Windows.Forms.Label();
            this.RateDays = new System.Windows.Forms.Label();
            this.MoviesQuantity = new System.Windows.Forms.Label();
            this.MoviesValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.RateText = new System.Windows.Forms.Label();
            this.DaysValue = new System.Windows.Forms.Label();
            this.EnterButtonRent = new System.Windows.Forms.Button();
            this.ClientSelector = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RentalDatePicker = new System.Windows.Forms.MaskedTextBox();
            this.ReturnDatePicker = new System.Windows.Forms.MaskedTextBox();
            this.TableMovies = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MovieSelector = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableMovies)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MovieValueSymbol);
            this.panel1.Controls.Add(this.DayValueSymbol);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.RateDays);
            this.panel1.Controls.Add(this.MoviesQuantity);
            this.panel1.Controls.Add(this.MoviesValue);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.RateText);
            this.panel1.Controls.Add(this.DaysValue);
            this.panel1.Location = new System.Drawing.Point(408, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 522);
            this.panel1.TabIndex = 27;
            // 
            // MovieValueSymbol
            // 
            this.MovieValueSymbol.AutoSize = true;
            this.MovieValueSymbol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieValueSymbol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MovieValueSymbol.Location = new System.Drawing.Point(320, 90);
            this.MovieValueSymbol.Name = "MovieValueSymbol";
            this.MovieValueSymbol.Size = new System.Drawing.Size(17, 20);
            this.MovieValueSymbol.TabIndex = 13;
            this.MovieValueSymbol.Text = "$";
            // 
            // DayValueSymbol
            // 
            this.DayValueSymbol.AutoSize = true;
            this.DayValueSymbol.BackColor = System.Drawing.SystemColors.Control;
            this.DayValueSymbol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DayValueSymbol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DayValueSymbol.Location = new System.Drawing.Point(320, 59);
            this.DayValueSymbol.Name = "DayValueSymbol";
            this.DayValueSymbol.Size = new System.Drawing.Size(17, 20);
            this.DayValueSymbol.TabIndex = 12;
            this.DayValueSymbol.Text = "$";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TotalPriceSymbol);
            this.panel3.Controls.Add(this.TotalValueSymbol);
            this.panel3.Controls.Add(this.TotalValue);
            this.panel3.Controls.Add(this.TotalValueText);
            this.panel3.Location = new System.Drawing.Point(-1, 473);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 48);
            this.panel3.TabIndex = 10;
            // 
            // TotalPriceSymbol
            // 
            this.TotalPriceSymbol.AutoSize = true;
            this.TotalPriceSymbol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalPriceSymbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalPriceSymbol.Location = new System.Drawing.Point(320, 15);
            this.TotalPriceSymbol.Name = "TotalPriceSymbol";
            this.TotalPriceSymbol.Size = new System.Drawing.Size(17, 20);
            this.TotalPriceSymbol.TabIndex = 14;
            this.TotalPriceSymbol.Text = "$";
            // 
            // TotalValueSymbol
            // 
            this.TotalValueSymbol.AutoSize = true;
            this.TotalValueSymbol.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalValueSymbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalValueSymbol.Location = new System.Drawing.Point(320, 15);
            this.TotalValueSymbol.Name = "TotalValueSymbol";
            this.TotalValueSymbol.Size = new System.Drawing.Size(0, 20);
            this.TotalValueSymbol.TabIndex = 11;
            // 
            // TotalValue
            // 
            this.TotalValue.AutoSize = true;
            this.TotalValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalValue.Location = new System.Drawing.Point(297, 15);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.Size = new System.Drawing.Size(17, 20);
            this.TotalValue.TabIndex = 4;
            this.TotalValue.Text = "0";
            // 
            // TotalValueText
            // 
            this.TotalValueText.AutoSize = true;
            this.TotalValueText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalValueText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalValueText.Location = new System.Drawing.Point(43, 15);
            this.TotalValueText.Name = "TotalValueText";
            this.TotalValueText.Size = new System.Drawing.Size(79, 18);
            this.TotalValueText.TabIndex = 3;
            this.TotalValueText.Text = "Total value:";
            // 
            // RateDays
            // 
            this.RateDays.AutoSize = true;
            this.RateDays.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RateDays.Location = new System.Drawing.Point(167, 59);
            this.RateDays.Name = "RateDays";
            this.RateDays.Size = new System.Drawing.Size(15, 18);
            this.RateDays.TabIndex = 9;
            this.RateDays.Text = "0";
            // 
            // MoviesQuantity
            // 
            this.MoviesQuantity.AutoSize = true;
            this.MoviesQuantity.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoviesQuantity.Location = new System.Drawing.Point(166, 90);
            this.MoviesQuantity.Name = "MoviesQuantity";
            this.MoviesQuantity.Size = new System.Drawing.Size(15, 18);
            this.MoviesQuantity.TabIndex = 8;
            this.MoviesQuantity.Text = "0";
            // 
            // MoviesValue
            // 
            this.MoviesValue.AutoSize = true;
            this.MoviesValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoviesValue.Location = new System.Drawing.Point(297, 90);
            this.MoviesValue.Name = "MoviesValue";
            this.MoviesValue.Size = new System.Drawing.Size(15, 18);
            this.MoviesValue.TabIndex = 7;
            this.MoviesValue.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(43, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 18);
            this.label10.TabIndex = 6;
            this.label10.Text = "Movies quantity:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 44);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(271, 43);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(95, 93);
            this.panel4.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(155, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Values";
            // 
            // RateText
            // 
            this.RateText.AutoSize = true;
            this.RateText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RateText.Location = new System.Drawing.Point(23, 59);
            this.RateText.Name = "RateText";
            this.RateText.Size = new System.Drawing.Size(129, 18);
            this.RateText.TabIndex = 0;
            this.RateText.Text = "Rate for the period:";
            // 
            // DaysValue
            // 
            this.DaysValue.AutoSize = true;
            this.DaysValue.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DaysValue.Location = new System.Drawing.Point(297, 59);
            this.DaysValue.Name = "DaysValue";
            this.DaysValue.Size = new System.Drawing.Size(15, 18);
            this.DaysValue.TabIndex = 5;
            this.DaysValue.Text = "0";
            // 
            // EnterButtonRent
            // 
            this.EnterButtonRent.BackColor = System.Drawing.Color.SlateBlue;
            this.EnterButtonRent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterButtonRent.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterButtonRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterButtonRent.Location = new System.Drawing.Point(341, 679);
            this.EnterButtonRent.Name = "EnterButtonRent";
            this.EnterButtonRent.Size = new System.Drawing.Size(103, 38);
            this.EnterButtonRent.TabIndex = 26;
            this.EnterButtonRent.Text = "Enter";
            this.EnterButtonRent.UseVisualStyleBackColor = false;
            this.EnterButtonRent.Click += new System.EventHandler(this.EnterButtonRent_Click);
            // 
            // ClientSelector
            // 
            this.ClientSelector.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientSelector.FormattingEnabled = true;
            this.ClientSelector.Location = new System.Drawing.Point(104, 67);
            this.ClientSelector.Name = "ClientSelector";
            this.ClientSelector.Size = new System.Drawing.Size(268, 26);
            this.ClientSelector.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(50, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Client:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(397, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Rental Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(577, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Return Date:";
            // 
            // RentalDatePicker
            // 
            this.RentalDatePicker.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentalDatePicker.Location = new System.Drawing.Point(491, 67);
            this.RentalDatePicker.Mask = "00/00";
            this.RentalDatePicker.Name = "RentalDatePicker";
            this.RentalDatePicker.Size = new System.Drawing.Size(72, 26);
            this.RentalDatePicker.TabIndex = 33;
            this.RentalDatePicker.ValidatingType = typeof(System.DateTime);
            this.RentalDatePicker.Leave += new System.EventHandler(this.RentalDatePicker_Leave);
            // 
            // ReturnDatePicker
            // 
            this.ReturnDatePicker.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnDatePicker.Location = new System.Drawing.Point(673, 67);
            this.ReturnDatePicker.Mask = "00/00";
            this.ReturnDatePicker.Name = "ReturnDatePicker";
            this.ReturnDatePicker.Size = new System.Drawing.Size(72, 26);
            this.ReturnDatePicker.TabIndex = 34;
            this.ReturnDatePicker.ValidatingType = typeof(System.DateTime);
            this.ReturnDatePicker.Leave += new System.EventHandler(this.ReturnDatePicker_Leave);
            // 
            // TableMovies
            // 
            this.TableMovies.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TableMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableMovies.Location = new System.Drawing.Point(23, 159);
            this.TableMovies.Name = "TableMovies";
            this.TableMovies.RowTemplate.Height = 25;
            this.TableMovies.Size = new System.Drawing.Size(350, 450);
            this.TableMovies.TabIndex = 37;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SlateBlue;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.AddButton);
            this.panel5.Location = new System.Drawing.Point(22, 616);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 31);
            this.panel5.TabIndex = 39;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.SlateBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddButton.Location = new System.Drawing.Point(-1, -2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(95, 32);
            this.AddButton.TabIndex = 40;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(29, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Movies:";
            // 
            // MovieSelector
            // 
            this.MovieSelector.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MovieSelector.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieSelector.Location = new System.Drawing.Point(94, 126);
            this.MovieSelector.Name = "MovieSelector";
            this.MovieSelector.Size = new System.Drawing.Size(229, 26);
            this.MovieSelector.TabIndex = 41;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.SlateBlue;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Search_button_2;
            this.SearchButton.Location = new System.Drawing.Point(324, 125);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(38, 28);
            this.SearchButton.TabIndex = 42;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(379, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(331, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 33);
            this.label5.TabIndex = 44;
            this.label5.Text = "Rent form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 651);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(772, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(772, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(793, 725);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.MovieSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.TableMovies);
            this.Controls.Add(this.ReturnDatePicker);
            this.Controls.Add(this.RentalDatePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClientSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EnterButtonRent);
            this.Name = "RentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableMovies)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button EnterButtonRent;
        private ComboBox ClientSelector;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaskedTextBox RentalDatePicker;
        private Label TotalValueText;
        private Panel panel2;
        private Label label7;
        private Label RateText;
        private MaskedTextBox ReturnDatePicker;
        private Panel panel3;
        private Label TotalValue;
        private Label RateDays;
        private Label MoviesQuantity;
        private Label MoviesValue;
        private Label label10;
        private Panel panel4;
        private Label DaysValue;
        private DataGridView TableMovies;
        private Panel panel5;
        private Button AddButton;
        private Label label1;
        private TextBox MovieSelector;
        private Button SearchButton;
        private Label MovieValueSymbol;
        private Label DayValueSymbol;
        private Label TotalValueSymbol;
        private Label label6;
        private Label TotalPriceSymbol;
        private Label label5;
        private Label label8;
        private Label label9;
    }
}