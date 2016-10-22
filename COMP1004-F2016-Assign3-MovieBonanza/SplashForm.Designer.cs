namespace COMP1004_F2016_Assign3_MovieBonanza
{
    partial class SplashForm
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
            this.components = new System.ComponentModel.Container();
            this.SplashPanel = new System.Windows.Forms.Panel();
            this.SplashAuthorLabel = new System.Windows.Forms.Label();
            this.SplashAssignmentLabel = new System.Windows.Forms.Label();
            this.SplashTitleLabel = new System.Windows.Forms.Label();
            this.FadeInTicker = new System.Windows.Forms.Timer(this.components);
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.FadeOutTicker = new System.Windows.Forms.Timer(this.components);
            this.SplashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplashPanel
            // 
            this.SplashPanel.BackColor = System.Drawing.Color.LightGray;
            this.SplashPanel.Controls.Add(this.SplashAuthorLabel);
            this.SplashPanel.Controls.Add(this.SplashAssignmentLabel);
            this.SplashPanel.Controls.Add(this.SplashTitleLabel);
            this.SplashPanel.Location = new System.Drawing.Point(12, 12);
            this.SplashPanel.Name = "SplashPanel";
            this.SplashPanel.Size = new System.Drawing.Size(411, 289);
            this.SplashPanel.TabIndex = 0;
            // 
            // SplashAuthorLabel
            // 
            this.SplashAuthorLabel.AutoSize = true;
            this.SplashAuthorLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SplashAuthorLabel.Location = new System.Drawing.Point(207, 258);
            this.SplashAuthorLabel.Name = "SplashAuthorLabel";
            this.SplashAuthorLabel.Size = new System.Drawing.Size(191, 20);
            this.SplashAuthorLabel.TabIndex = 3;
            this.SplashAuthorLabel.Text = "Adam Bates | 200335831";
            // 
            // SplashAssignmentLabel
            // 
            this.SplashAssignmentLabel.AutoSize = true;
            this.SplashAssignmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashAssignmentLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SplashAssignmentLabel.Location = new System.Drawing.Point(68, 75);
            this.SplashAssignmentLabel.Name = "SplashAssignmentLabel";
            this.SplashAssignmentLabel.Size = new System.Drawing.Size(196, 16);
            this.SplashAssignmentLabel.TabIndex = 2;
            this.SplashAssignmentLabel.Text = "COMP1004_F2016_Assign3_MovieBonanza";
            // 
            // SplashTitleLabel
            // 
            this.SplashTitleLabel.AutoSize = true;
            this.SplashTitleLabel.Font = new System.Drawing.Font("HP Simplified", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashTitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SplashTitleLabel.Location = new System.Drawing.Point(63, 36);
            this.SplashTitleLabel.Name = "SplashTitleLabel";
            this.SplashTitleLabel.Size = new System.Drawing.Size(281, 49);
            this.SplashTitleLabel.TabIndex = 1;
            this.SplashTitleLabel.Text = "MOVIE BONANZA";
            // 
            // FadeInTicker
            // 
            this.FadeInTicker.Enabled = true;
            this.FadeInTicker.Interval = 10;
            this.FadeInTicker.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 2000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // FadeOutTicker
            // 
            this.FadeOutTicker.Interval = 10;
            this.FadeOutTicker.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(435, 313);
            this.Controls.Add(this.SplashPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SplashForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.SplashPanel.ResumeLayout(false);
            this.SplashPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SplashPanel;
        private System.Windows.Forms.Timer FadeInTicker;
        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Timer FadeOutTicker;
        private System.Windows.Forms.Label SplashAssignmentLabel;
        private System.Windows.Forms.Label SplashTitleLabel;
        private System.Windows.Forms.Label SplashAuthorLabel;
    }
}