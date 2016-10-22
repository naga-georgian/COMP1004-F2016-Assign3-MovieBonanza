namespace COMP1004_F2016_Assign3_MovieBonanza
{
    partial class SelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectionForm));
            this.CurrentMovieComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.RentComboBox = new System.Windows.Forms.ComboBox();
            this.RentRadioButton = new System.Windows.Forms.RadioButton();
            this.BuyRadioButton = new System.Windows.Forms.RadioButton();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.CurrentMoviesLabel = new System.Windows.Forms.Label();
            this.SelectionFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SignUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DescriptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SignUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PurchaseButton = new System.Windows.Forms.Button();
            this.FormInfoTextBox = new System.Windows.Forms.TextBox();
            this.MoviePictureBox = new System.Windows.Forms.PictureBox();
            this.SelectedMovieGroupBox.SuspendLayout();
            this.SelectionFormMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMovieComboBox
            // 
            this.CurrentMovieComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.CurrentMovieComboBox.DropDownHeight = 200;
            this.CurrentMovieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CurrentMovieComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMovieComboBox.FormattingEnabled = true;
            this.CurrentMovieComboBox.IntegralHeight = false;
            this.CurrentMovieComboBox.Items.AddRange(new object[] {
            "A Few Good Men",
            "Batman Begins",
            "Finding Dory",
            "Finding Nemo",
            "Forest Gump",
            "Gravity",
            "Guardians of the Galaxy",
            "Inception",
            "Interstellar",
            "LotR: The Fellowship of the Ring",
            "LotR: The Return of the King",
            "LotR: The Two Towers",
            "Pulp Fiction",
            "Star Wars - A New Hope",
            "Star Wars - Attack of the Clones",
            "Star Wars - Return of the Jedi",
            "Star Wars - Revenge of the Sith",
            "Star Wars - The Empire Strikes Back",
            "Star Wars - The Force Awakens",
            "Star Wars - The Phantom Menace",
            "Suicide Squad",
            "The Dark Knight",
            "The Dark Knight Rises",
            "The Godfather",
            "The Godfather: Part II",
            "The Godfather: Part III",
            "The Shawshank Redemption",
            "The Social Network",
            "The Wolf of Wall Street",
            "Top Gun"});
            this.CurrentMovieComboBox.Location = new System.Drawing.Point(165, 43);
            this.CurrentMovieComboBox.Name = "CurrentMovieComboBox";
            this.CurrentMovieComboBox.Size = new System.Drawing.Size(283, 24);
            this.CurrentMovieComboBox.Sorted = true;
            this.CurrentMovieComboBox.TabIndex = 0;
            this.CurrentMovieComboBox.SelectedIndexChanged += new System.EventHandler(this.CurrentMovieComboBox_SelectedIndexChanged);
            // 
            // SelectedMovieGroupBox
            // 
            this.SelectedMovieGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.SelectedMovieGroupBox.Controls.Add(this.DescriptionTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.DescriptionLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.GenreTextBox);
            this.SelectedMovieGroupBox.Controls.Add(this.GenreLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.RentComboBox);
            this.SelectedMovieGroupBox.Controls.Add(this.RentRadioButton);
            this.SelectedMovieGroupBox.Controls.Add(this.BuyRadioButton);
            this.SelectedMovieGroupBox.Controls.Add(this.MovieTitleLabel);
            this.SelectedMovieGroupBox.Controls.Add(this.MoviePictureBox);
            this.SelectedMovieGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedMovieGroupBox.Location = new System.Drawing.Point(12, 73);
            this.SelectedMovieGroupBox.Name = "SelectedMovieGroupBox";
            this.SelectedMovieGroupBox.Size = new System.Drawing.Size(436, 203);
            this.SelectedMovieGroupBox.TabIndex = 1;
            this.SelectedMovieGroupBox.TabStop = false;
            this.SelectedMovieGroupBox.Text = "Selected Movie";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.LightGray;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(153, 134);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(272, 69);
            this.DescriptionTextBox.TabIndex = 8;
            this.DescriptionTextBox.TabStop = false;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(149, 111);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(110, 20);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description :";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.BackColor = System.Drawing.Color.LightGray;
            this.GenreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenreTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextBox.Location = new System.Drawing.Point(224, 90);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.ReadOnly = true;
            this.GenreTextBox.Size = new System.Drawing.Size(206, 19);
            this.GenreTextBox.TabIndex = 6;
            this.GenreTextBox.TabStop = false;
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.Location = new System.Drawing.Point(149, 89);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(69, 20);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Genre :";
            // 
            // RentComboBox
            // 
            this.RentComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.RentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RentComboBox.Enabled = false;
            this.RentComboBox.FormattingEnabled = true;
            this.RentComboBox.Items.AddRange(new object[] {
            "24 hrs",
            "48 hrs"});
            this.RentComboBox.Location = new System.Drawing.Point(311, 59);
            this.RentComboBox.Name = "RentComboBox";
            this.RentComboBox.Size = new System.Drawing.Size(73, 24);
            this.RentComboBox.TabIndex = 4;
            this.RentComboBox.SelectedValueChanged += new System.EventHandler(this.RentComboBox_SelectedValueChanged);
            // 
            // RentRadioButton
            // 
            this.RentRadioButton.AutoSize = true;
            this.RentRadioButton.Location = new System.Drawing.Point(251, 60);
            this.RentRadioButton.Name = "RentRadioButton";
            this.RentRadioButton.Size = new System.Drawing.Size(54, 20);
            this.RentRadioButton.TabIndex = 3;
            this.RentRadioButton.Text = "Rent";
            this.RentRadioButton.UseVisualStyleBackColor = true;
            this.RentRadioButton.CheckedChanged += new System.EventHandler(this.PurchaseRadioButton_CheckedChanged);
            // 
            // BuyRadioButton
            // 
            this.BuyRadioButton.AutoSize = true;
            this.BuyRadioButton.Checked = true;
            this.BuyRadioButton.Location = new System.Drawing.Point(153, 59);
            this.BuyRadioButton.Name = "BuyRadioButton";
            this.BuyRadioButton.Size = new System.Drawing.Size(92, 20);
            this.BuyRadioButton.TabIndex = 2;
            this.BuyRadioButton.TabStop = true;
            this.BuyRadioButton.Text = "Buy to Own";
            this.BuyRadioButton.UseVisualStyleBackColor = true;
            this.BuyRadioButton.CheckedChanged += new System.EventHandler(this.PurchaseRadioButton_CheckedChanged);
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieTitleLabel.Location = new System.Drawing.Point(149, 9);
            this.MovieTitleLabel.MaximumSize = new System.Drawing.Size(275, 0);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(112, 24);
            this.MovieTitleLabel.TabIndex = 2;
            this.MovieTitleLabel.Text = "Movie Title";
            // 
            // CurrentMoviesLabel
            // 
            this.CurrentMoviesLabel.AutoSize = true;
            this.CurrentMoviesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentMoviesLabel.Location = new System.Drawing.Point(8, 40);
            this.CurrentMoviesLabel.Name = "CurrentMoviesLabel";
            this.CurrentMoviesLabel.Size = new System.Drawing.Size(151, 24);
            this.CurrentMoviesLabel.TabIndex = 0;
            this.CurrentMoviesLabel.Text = "Current Movies";
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
            this.SelectionFormMenuStrip.Size = new System.Drawing.Size(459, 25);
            this.SelectionFormMenuStrip.TabIndex = 2;
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
            this.AccountMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // LoginMenuItem
            // 
            this.LoginMenuItem.Name = "LoginMenuItem";
            this.LoginMenuItem.Size = new System.Drawing.Size(122, 22);
            this.LoginMenuItem.Text = "Login";
            this.LoginMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // SignUpMenuItem
            // 
            this.SignUpMenuItem.Name = "SignUpMenuItem";
            this.SignUpMenuItem.Size = new System.Drawing.Size(122, 22);
            this.SignUpMenuItem.Text = "Sign Up";
            this.SignUpMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DescriptionMenuItem});
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(42, 21);
            this.EditMenuItem.Text = "Edit";
            // 
            // DescriptionMenuItem
            // 
            this.DescriptionMenuItem.Name = "DescriptionMenuItem";
            this.DescriptionMenuItem.Size = new System.Drawing.Size(142, 22);
            this.DescriptionMenuItem.Text = "Description";
            this.DescriptionMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
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
            this.AboutMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // LoginLinkLabel
            // 
            this.LoginLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.LoginLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginLinkLabel.AutoSize = true;
            this.LoginLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LoginLinkLabel.LinkColor = System.Drawing.SystemColors.ControlText;
            this.LoginLinkLabel.Location = new System.Drawing.Point(342, 0);
            this.LoginLinkLabel.Name = "LoginLinkLabel";
            this.LoginLinkLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.LoginLinkLabel.Size = new System.Drawing.Size(40, 21);
            this.LoginLinkLabel.TabIndex = 3;
            this.LoginLinkLabel.TabStop = true;
            this.LoginLinkLabel.Text = "Login";
            this.LoginLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.LoginLinkLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AccountLabelLink_MouseDown);
            this.LoginLinkLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AccountLabelLink_MouseUp);
            // 
            // SignUpLinkLabel
            // 
            this.SignUpLinkLabel.ActiveLinkColor = System.Drawing.SystemColors.ControlText;
            this.SignUpLinkLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUpLinkLabel.AutoSize = true;
            this.SignUpLinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.SignUpLinkLabel.LinkColor = System.Drawing.SystemColors.ControlText;
            this.SignUpLinkLabel.Location = new System.Drawing.Point(394, 0);
            this.SignUpLinkLabel.Name = "SignUpLinkLabel";
            this.SignUpLinkLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.SignUpLinkLabel.Size = new System.Drawing.Size(54, 21);
            this.SignUpLinkLabel.TabIndex = 4;
            this.SignUpLinkLabel.TabStop = true;
            this.SignUpLinkLabel.Text = "Sign Up";
            this.SignUpLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpLinkLabel.VisitedLinkColor = System.Drawing.SystemColors.ControlText;
            this.SignUpLinkLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AccountLabelLink_MouseDown);
            this.SignUpLinkLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AccountLabelLink_MouseUp);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(14, 290);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(58, 24);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.Visible = false;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.BackColor = System.Drawing.Color.Silver;
            this.PriceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(78, 292);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(120, 22);
            this.PriceTextBox.TabIndex = 10;
            this.PriceTextBox.TabStop = false;
            // 
            // PurchaseButton
            // 
            this.PurchaseButton.AutoSize = true;
            this.PurchaseButton.Enabled = false;
            this.PurchaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchaseButton.Location = new System.Drawing.Point(379, 287);
            this.PurchaseButton.Name = "PurchaseButton";
            this.PurchaseButton.Size = new System.Drawing.Size(69, 34);
            this.PurchaseButton.TabIndex = 11;
            this.PurchaseButton.Text = "Next";
            this.PurchaseButton.UseVisualStyleBackColor = true;
            this.PurchaseButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // FormInfoTextBox
            // 
            this.FormInfoTextBox.BackColor = System.Drawing.Color.Silver;
            this.FormInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormInfoTextBox.Location = new System.Drawing.Point(12, 323);
            this.FormInfoTextBox.Name = "FormInfoTextBox";
            this.FormInfoTextBox.Size = new System.Drawing.Size(435, 13);
            this.FormInfoTextBox.TabIndex = 12;
            this.FormInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MoviePictureBox
            // 
            this.MoviePictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MoviePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoviePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MoviePictureBox.Image")));
            this.MoviePictureBox.Location = new System.Drawing.Point(6, 21);
            this.MoviePictureBox.Name = "MoviePictureBox";
            this.MoviePictureBox.Size = new System.Drawing.Size(141, 170);
            this.MoviePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoviePictureBox.TabIndex = 2;
            this.MoviePictureBox.TabStop = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(459, 348);
            this.Controls.Add(this.FormInfoTextBox);
            this.Controls.Add(this.PurchaseButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.SignUpLinkLabel);
            this.Controls.Add(this.LoginLinkLabel);
            this.Controls.Add(this.CurrentMoviesLabel);
            this.Controls.Add(this.SelectedMovieGroupBox);
            this.Controls.Add(this.CurrentMovieComboBox);
            this.Controls.Add(this.SelectionFormMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.SelectionFormMenuStrip;
            this.Name = "SelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection | Movie Bonanza";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectionForm_FormClosing);
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.SelectedMovieGroupBox.ResumeLayout(false);
            this.SelectedMovieGroupBox.PerformLayout();
            this.SelectionFormMenuStrip.ResumeLayout(false);
            this.SelectionFormMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrentMovieComboBox;
        private System.Windows.Forms.GroupBox SelectedMovieGroupBox;
        private System.Windows.Forms.Label CurrentMoviesLabel;
        private System.Windows.Forms.PictureBox MoviePictureBox;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.ComboBox RentComboBox;
        private System.Windows.Forms.RadioButton RentRadioButton;
        private System.Windows.Forms.RadioButton BuyRadioButton;
        private System.Windows.Forms.MenuStrip SelectionFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.LinkLabel LoginLinkLabel;
        private System.Windows.Forms.LinkLabel SignUpLinkLabel;
        private System.Windows.Forms.ToolStripMenuItem AccountMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoginMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SignUpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button PurchaseButton;
        private System.Windows.Forms.ToolStripMenuItem DescriptionMenuItem;
        private System.Windows.Forms.TextBox FormInfoTextBox;
    }
}

