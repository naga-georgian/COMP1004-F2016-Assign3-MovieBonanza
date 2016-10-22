namespace COMP1004_F2016_Assign3_MovieBonanza
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.SelectionFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescriptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectedMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PurchaseLabel = new System.Windows.Forms.Label();
            this.SubTotalCostLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrderDvdCheckBox = new System.Windows.Forms.CheckBox();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.TaxCostLabel = new System.Windows.Forms.Label();
            this.PriceCostLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.OrderButton = new System.Windows.Forms.Button();
            this.SelectionFormMenuStrip.SuspendLayout();
            this.SelectedMovieGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectionFormMenuStrip
            // 
            this.SelectionFormMenuStrip.BackColor = System.Drawing.Color.Silver;
            this.SelectionFormMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectionFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.EditMenuItem,
            this.HelpMenuItem});
            this.SelectionFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.SelectionFormMenuStrip.Name = "SelectionFormMenuStrip";
            this.SelectionFormMenuStrip.Size = new System.Drawing.Size(500, 25);
            this.SelectionFormMenuStrip.TabIndex = 3;
            this.SelectionFormMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(39, 21);
            this.FileMenuItem.Text = "File";
            // 
            // AccountMenuItem
            // 
            this.AccountMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginMenuItem,
            this.SignUpMenuItem});
            this.AccountMenuItem.Name = "AccountMenuItem";
            this.AccountMenuItem.Size = new System.Drawing.Size(122, 22);
            this.AccountMenuItem.Text = "Account";
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(122, 22);
            this.LoginMenuItem.Text = "Login";
            // 
            // SignUpMenuItem
            // 
            this.SignUpMenuItem.Name = "SignUpMenuItem";
            this.SignUpMenuItem.Size = new System.Drawing.Size(122, 22);
            this.SignUpMenuItem.Text = "Sign Up";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ExitMenuItem.Text = "Exit";
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DescriptionMenuItem,
            this.PurchaseMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(42, 21);
            this.EditMenuItem.Text = "Edit";
            // 
            // DescriptionMenuItem
            // 
            this.DescriptionMenuItem.Name = "DescriptionMenuItem";
            this.DescriptionMenuItem.Size = new System.Drawing.Size(142, 22);
            this.DescriptionMenuItem.Text = "Description";
            // 
            // PurchaseMenuItem
            // 
            this.PurchaseMenuItem.Name = "PurchaseMenuItem";
            this.PurchaseMenuItem.Size = new System.Drawing.Size(142, 22);
            this.PurchaseMenuItem.Text = "Purchase";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(47, 21);
            this.HelpMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(111, 22);
            this.AboutMenuItem.Text = "About";
            // 
            // SelectedMovieGroupBox
            // 
            this.SelectedMovieGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.SelectedMovieGroupBox.Controls.Add(this.MoviePictureBox);
            this.SelectedMovieGroupBox.Controls.Add(this.MovieTitleLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.GenreTextBox);
            this.SelectedMovieGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedMovieGroupBox.Location = new System.Drawing.Point(12, 28);
            this.SelectedMovieGroupBox.Name = "SelectedMovieGroupBox";
            this.SelectedMovieGroupBox.Size = new System.Drawing.Size(252, 320);
            this.SelectedMovieGroupBox.TabIndex = 4;
            this.SelectedMovieGroupBox.TabStop = false;
            this.SelectedMovieGroupBox.Text = "Selected Movie";
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoviePictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("MoviePictureBox.ErrorImage")));
            this.MoviePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MoviePictureBox.Image")));
            this.MoviePictureBox.Location = new System.Drawing.Point(6, 100);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(181, 213);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePictureBox.TabIndex = 2;
            this.MoviePictureBox.TabStop = false;
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(6, 18);
            this.MovieTitleLabel.MaximumSize = new System.Drawing.Size(265, 0);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(112, 24);
            this.MovieTitleLabel.TabIndex = 2;
            this.MovieTitleLabel.Text = "Movie Title";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(6, 73);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(69, 20);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Genre :";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.BackColor = System.Drawing.Color.LightGray;
            this.GenreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenreTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextBox.Location = new System.Drawing.Point(81, 75);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.ReadOnly = true;
            this.GenreTextBox.Size = new System.Drawing.Size(165, 19);
            this.GenreTextBox.TabIndex = 6;
            this.GenreTextBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.PurchaseLabel);
            this.groupBox1.Controls.Add(this.SubTotalCostLabel);
            this.groupBox1.Controls.Add(this.SubTotalLabel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.OrderDvdCheckBox);
            this.groupBox1.Controls.Add(this.TotalCostLabel);
            this.groupBox1.Controls.Add(this.TaxCostLabel);
            this.groupBox1.Controls.Add(this.PriceCostLabel);
            this.groupBox1.Controls.Add(this.TotalLabel);
            this.groupBox1.Controls.Add(this.TaxLabel);
            this.groupBox1.Controls.Add(this.PriceLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(270, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 211);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // PurchaseLabel
            // 
            this.PurchaseLabel.AutoSize = true;
            this.PurchaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseLabel.Location = new System.Drawing.Point(49, 18);
            this.PurchaseLabel.MaximumSize = new System.Drawing.Size(265, 0);
            this.PurchaseLabel.Name = "PurchaseLabel";
            this.PurchaseLabel.Size = new System.Drawing.Size(98, 24);
            this.PurchaseLabel.TabIndex = 9;
            this.PurchaseLabel.Text = "Purchase";
            // 
            // SubTotalCostLabel
            // 
            this.SubTotalCostLabel.AutoSize = true;
            this.SubTotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalCostLabel.Location = new System.Drawing.Point(114, 118);
            this.SubTotalCostLabel.Name = "SubTotalCostLabel";
            this.SubTotalCostLabel.Size = new System.Drawing.Size(54, 20);
            this.SubTotalCostLabel.TabIndex = 8;
            this.SubTotalCostLabel.Text = "$0.00";
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(17, 118);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(91, 20);
            this.SubTotalLabel.TabIndex = 7;
            this.SubTotalLabel.Text = "SubTotal :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "---------------------------------";
            // 
            // OrderDvdCheckBox
            // 
            this.OrderDvdCheckBox.AutoSize = true;
            this.OrderDvdCheckBox.Location = new System.Drawing.Point(30, 86);
            this.OrderDvdCheckBox.Name = "OrderDvdCheckBox";
            this.OrderDvdCheckBox.Size = new System.Drawing.Size(173, 20);
            this.OrderDvdCheckBox.TabIndex = 6;
            this.OrderDvdCheckBox.Text = "Order the DVD (+ $10.00)";
            this.OrderDvdCheckBox.UseVisualStyleBackColor = true;
            this.OrderDvdCheckBox.CheckedChanged += new System.EventHandler(this.OrderDvdCheckBox_CheckedChanged);
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(114, 184);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(54, 20);
            this.TotalCostLabel.TabIndex = 5;
            this.TotalCostLabel.Text = "$0.00";
            // 
            // TaxCostLabel
            // 
            this.TaxCostLabel.AutoSize = true;
            this.TaxCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxCostLabel.Location = new System.Drawing.Point(114, 154);
            this.TaxCostLabel.Name = "TaxCostLabel";
            this.TaxCostLabel.Size = new System.Drawing.Size(54, 20);
            this.TaxCostLabel.TabIndex = 4;
            this.TaxCostLabel.Text = "$0.00";
            // 
            // PriceCostLabel
            // 
            this.PriceCostLabel.AutoSize = true;
            this.PriceCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceCostLabel.Location = new System.Drawing.Point(114, 54);
            this.PriceCostLabel.Name = "PriceCostLabel";
            this.PriceCostLabel.Size = new System.Drawing.Size(54, 20);
            this.PriceCostLabel.TabIndex = 3;
            this.PriceCostLabel.Text = "$0.00";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(49, 184);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(59, 20);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total :";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.Location = new System.Drawing.Point(9, 154);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(99, 20);
            this.TaxLabel.TabIndex = 1;
            this.TaxLabel.Text = "Tax (13%) :";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(49, 54);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(59, 20);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price :";
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(270, 314);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(69, 34);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // OrderButton
            // 
            this.OrderButton.AutoSize = true;
            this.OrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.Location = new System.Drawing.Point(419, 314);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(69, 34);
            this.OrderButton.TabIndex = 13;
            this.OrderButton.Text = "Order";
            this.OrderButton.UseVisualStyleBackColor = true;
            this.OrderButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(500, 357);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectedMovieGroupBox);
            this.Controls.Add(this.SelectionFormMenuStrip);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form | Movie Bonanza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.SelectionFormMenuStrip.ResumeLayout(false);
            this.SelectionFormMenuStrip.PerformLayout();
            this.SelectedMovieGroupBox.ResumeLayout(false);
            this.SelectedMovieGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip SelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignUpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DescriptionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.GroupBox SelectedMovieGroupBox;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SubTotalCostLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox OrderDvdCheckBox;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label TaxCostLabel;
        private System.Windows.Forms.Label PriceCostLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label PurchaseLabel;
        private System.Windows.Forms.Button OrderButton;
    }
}