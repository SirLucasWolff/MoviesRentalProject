﻿namespace MoviesRental.WindowsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StatusFooter = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeOption = new System.Windows.Forms.ToolStripMenuItem();
            this.MovieOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientOption = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FrameworkMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RentsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RegisterSelectedText = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DevolutionButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.EditButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AccountButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.FilterButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshButton = new System.Windows.Forms.ToolStripButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.CheckStatusRent = new System.Windows.Forms.Timer(this.components);
            this.StatusFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusFooter
            // 
            this.StatusFooter.BackColor = System.Drawing.SystemColors.Control;
            this.StatusFooter.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.StatusFooter.Location = new System.Drawing.Point(0, 682);
            this.StatusFooter.Name = "StatusFooter";
            this.StatusFooter.Size = new System.Drawing.Size(1231, 22);
            this.StatusFooter.TabIndex = 0;
            this.StatusFooter.Text = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.BackColor = System.Drawing.Color.Snow;
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccessMenuItem,
            this.RegistersMenuItem,
            this.SettingsMenuItem,
            this.RentsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1231, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccessMenuItem
            // 
            this.AccessMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessMenuItem.Name = "AccessMenuItem";
            this.AccessMenuItem.Size = new System.Drawing.Size(61, 22);
            this.AccessMenuItem.Text = "Access";
            this.AccessMenuItem.Click += new System.EventHandler(this.AccessMenuItem_Click);
            // 
            // RegistersMenuItem
            // 
            this.RegistersMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeOption,
            this.MovieOption,
            this.ClientOption});
            this.RegistersMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegistersMenuItem.Name = "RegistersMenuItem";
            this.RegistersMenuItem.Size = new System.Drawing.Size(77, 22);
            this.RegistersMenuItem.Text = "Registers";
            // 
            // EmployeeOption
            // 
            this.EmployeeOption.Name = "EmployeeOption";
            this.EmployeeOption.Size = new System.Drawing.Size(138, 22);
            this.EmployeeOption.Text = "Employee";
            this.EmployeeOption.Click += new System.EventHandler(this.EmployeeOption_Click);
            // 
            // MovieOption
            // 
            this.MovieOption.Name = "MovieOption";
            this.MovieOption.Size = new System.Drawing.Size(138, 22);
            this.MovieOption.Text = "Movie";
            this.MovieOption.Click += new System.EventHandler(this.MovieOption_Click);
            // 
            // ClientOption
            // 
            this.ClientOption.Name = "ClientOption";
            this.ClientOption.Size = new System.Drawing.Size(138, 22);
            this.ClientOption.Text = "Client";
            this.ClientOption.Click += new System.EventHandler(this.ClientOption_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SettingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FrameworkMenuItem});
            this.SettingsMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(69, 22);
            this.SettingsMenuItem.Text = "Settings";
            // 
            // FrameworkMenuItem
            // 
            this.FrameworkMenuItem.Name = "FrameworkMenuItem";
            this.FrameworkMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FrameworkMenuItem.Text = "Framework";
            this.FrameworkMenuItem.Click += new System.EventHandler(this.FrameworkMenuItem_Click);
            // 
            // RentsMenuItem
            // 
            this.RentsMenuItem.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RentsMenuItem.Name = "RentsMenuItem";
            this.RentsMenuItem.Size = new System.Drawing.Size(55, 22);
            this.RentsMenuItem.Text = "Rents";
            this.RentsMenuItem.Click += new System.EventHandler(this.RentsMenuItem_Click);
            // 
            // PanelHeader
            // 
            this.PanelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PanelHeader.Controls.Add(this.toolStrip1);
            this.PanelHeader.Location = new System.Drawing.Point(0, 29);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1231, 51);
            this.PanelHeader.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegisterSelectedText,
            this.toolStripSeparator1,
            this.AddButton,
            this.toolStripSeparator2,
            this.DevolutionButton,
            this.toolStripSeparator6,
            this.EditButton,
            this.toolStripSeparator3,
            this.DeleteButton,
            this.toolStripSeparator4,
            this.AccountButton,
            this.toolStripSeparator5,
            this.FilterButton,
            this.toolStripSeparator7,
            this.RefreshButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(138, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RegisterSelectedText
            // 
            this.RegisterSelectedText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterSelectedText.Name = "RegisterSelectedText";
            this.RegisterSelectedText.Size = new System.Drawing.Size(0, 36);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // AddButton
            // 
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Delete_icon;
            this.AddButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(36, 36);
            this.AddButton.Text = "toolStripButton1";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // DevolutionButton
            // 
            this.DevolutionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DevolutionButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DevolutionButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Devolution_Button;
            this.DevolutionButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DevolutionButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DevolutionButton.Name = "DevolutionButton";
            this.DevolutionButton.Size = new System.Drawing.Size(36, 36);
            this.DevolutionButton.Text = "Register the devolution";
            this.DevolutionButton.Click += new System.EventHandler(this.DevolutionButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // EditButton
            // 
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Edit_icon;
            this.EditButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(36, 36);
            this.EditButton.Text = "toolStripButton2";
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // DeleteButton
            // 
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Add_icon;
            this.DeleteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(36, 36);
            this.DeleteButton.Text = "toolStripButton3";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 6);
            // 
            // AccountButton
            // 
            this.AccountButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AccountButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.account_button;
            this.AccountButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.AccountButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(36, 36);
            this.AccountButton.Text = "toolStripButton1";
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // FilterButton
            // 
            this.FilterButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Filter_Button;
            this.FilterButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterButton.MergeIndex = -10;
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.Size = new System.Drawing.Size(36, 36);
            this.FilterButton.Text = "Filter";
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 6);
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Image = global::MoviesRental.WindowsApp.Properties.Resources.Refresh_icon;
            this.RefreshButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(36, 36);
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.ToolTipText = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.MainPanel.Controls.Add(this.LogoPictureBox);
            this.MainPanel.Controls.Add(this.DashboardPanel);
            this.MainPanel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainPanel.Location = new System.Drawing.Point(0, 71);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1231, 608);
            this.MainPanel.TabIndex = 3;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoPictureBox.Image = global::MoviesRental.WindowsApp.Properties.Resources.Logo_project;
            this.LogoPictureBox.Location = new System.Drawing.Point(151, 42);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(724, 397);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DashboardPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DashboardPanel.Location = new System.Drawing.Point(244, 122);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(746, 233);
            this.DashboardPanel.TabIndex = 1;
            // 
            // CheckStatusRent
            // 
            this.CheckStatusRent.Enabled = true;
            this.CheckStatusRent.Interval = 100000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1231, 704);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.StatusFooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusFooter.ResumeLayout(false);
            this.StatusFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip StatusFooter;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem RegistersMenuItem;
        private ToolStripMenuItem EmployeeOption;
        private ToolStripMenuItem MovieOption;
        private ToolStripMenuItem ClientOption;
        private Panel PanelHeader;
        private ToolStrip toolStrip1;
        private ToolStripLabel RegisterSelectedText;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton AddButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton EditButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton DeleteButton;
        private Panel MainPanel;
        public ToolStripStatusLabel StatusText;
        private ToolStripMenuItem AccessMenuItem;
        private ToolStripMenuItem SettingsMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton AccountButton;
        private ToolStripMenuItem RentsMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton FilterButton;
        private System.Windows.Forms.Timer CheckStatusRent;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton DevolutionButton;
        private ToolStripMenuItem FrameworkMenuItem;
        private PictureBox LogoPictureBox;
        private Panel DashboardPanel;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton RefreshButton;
    }
}