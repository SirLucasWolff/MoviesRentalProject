namespace MoviesRental.WindowsApp.Features.MovieModule
{
    partial class MovieForm
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
            this.EnterButtonMovie = new System.Windows.Forms.Button();
            this.TextMovieName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CategorySelector = new System.Windows.Forms.ComboBox();
            this.ClassificationSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReleaseDatePicker = new System.Windows.Forms.MaskedTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MovieStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBoxCategories = new System.Windows.Forms.TextBox();
            this.ClearCategoriesButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnterButtonMovie
            // 
            this.EnterButtonMovie.BackColor = System.Drawing.Color.SlateBlue;
            this.EnterButtonMovie.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterButtonMovie.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterButtonMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterButtonMovie.Location = new System.Drawing.Point(181, 276);
            this.EnterButtonMovie.Name = "EnterButtonMovie";
            this.EnterButtonMovie.Size = new System.Drawing.Size(103, 38);
            this.EnterButtonMovie.TabIndex = 19;
            this.EnterButtonMovie.Text = "Enter";
            this.EnterButtonMovie.UseVisualStyleBackColor = false;
            this.EnterButtonMovie.Click += new System.EventHandler(this.EnterButtonMovie_Click);
            // 
            // TextMovieName
            // 
            this.TextMovieName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextMovieName.Location = new System.Drawing.Point(135, 58);
            this.TextMovieName.Name = "TextMovieName";
            this.TextMovieName.Size = new System.Drawing.Size(258, 26);
            this.TextMovieName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(59, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(80, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Name:";
            // 
            // CategorySelector
            // 
            this.CategorySelector.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategorySelector.FormattingEnabled = true;
            this.CategorySelector.Location = new System.Drawing.Point(135, 122);
            this.CategorySelector.Name = "CategorySelector";
            this.CategorySelector.Size = new System.Drawing.Size(258, 26);
            this.CategorySelector.TabIndex = 20;
            this.CategorySelector.SelectedValueChanged += new System.EventHandler(this.CategorySelector_SelectedValueChanged);
            // 
            // ClassificationSelector
            // 
            this.ClassificationSelector.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassificationSelector.FormattingEnabled = true;
            this.ClassificationSelector.Location = new System.Drawing.Point(135, 90);
            this.ClassificationSelector.Name = "ClassificationSelector";
            this.ClassificationSelector.Size = new System.Drawing.Size(258, 26);
            this.ClassificationSelector.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(37, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Classification:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Release date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(152, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 33);
            this.label3.TabIndex = 26;
            this.label3.Text = "Movie form";
            // 
            // ReleaseDatePicker
            // 
            this.ReleaseDatePicker.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseDatePicker.Location = new System.Drawing.Point(135, 219);
            this.ReleaseDatePicker.Mask = "00/00/0000";
            this.ReleaseDatePicker.Name = "ReleaseDatePicker";
            this.ReleaseDatePicker.Size = new System.Drawing.Size(97, 26);
            this.ReleaseDatePicker.TabIndex = 27;
            this.ReleaseDatePicker.ValidatingType = typeof(System.DateTime);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovieStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 326);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(455, 22);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MovieStatusText
            // 
            this.MovieStatusText.Name = "MovieStatusText";
            this.MovieStatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // TextBoxCategories
            // 
            this.TextBoxCategories.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxCategories.Location = new System.Drawing.Point(135, 154);
            this.TextBoxCategories.Multiline = true;
            this.TextBoxCategories.Name = "TextBoxCategories";
            this.TextBoxCategories.Size = new System.Drawing.Size(255, 59);
            this.TextBoxCategories.TabIndex = 29;
            // 
            // ClearCategoriesButton
            // 
            this.ClearCategoriesButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Clear_categories;
            this.ClearCategoriesButton.Location = new System.Drawing.Point(394, 190);
            this.ClearCategoriesButton.Name = "ClearCategoriesButton";
            this.ClearCategoriesButton.Size = new System.Drawing.Size(29, 23);
            this.ClearCategoriesButton.TabIndex = 30;
            this.ClearCategoriesButton.UseVisualStyleBackColor = true;
            this.ClearCategoriesButton.Click += new System.EventHandler(this.ClearCategoriesButton_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(455, 348);
            this.Controls.Add(this.ClearCategoriesButton);
            this.Controls.Add(this.TextBoxCategories);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ReleaseDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnterButtonMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextMovieName);
            this.Controls.Add(this.CategorySelector);
            this.Controls.Add(this.ClassificationSelector);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "MovieForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MovieForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EnterButtonMovie;
        private TextBox TextMovieName;
        private Label label5;
        private Label label6;
        private ComboBox CategorySelector;
        private ComboBox ClassificationSelector;
        private Label label1;
        private Label label2;
        private Label label3;
        private MaskedTextBox ReleaseDatePicker;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel MovieStatusText;
        private TextBox TextBoxCategories;
        private Button ClearCategoriesButton;
    }
}