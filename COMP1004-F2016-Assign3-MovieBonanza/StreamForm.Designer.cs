namespace COMP1004_F2016_Assign3_MovieBonanza
{
    partial class StreamForm
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
            this.ThankYouLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SmilePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SmilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ThankYouLabel
            // 
            this.ThankYouLabel.AutoSize = true;
            this.ThankYouLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThankYouLabel.Location = new System.Drawing.Point(47, 21);
            this.ThankYouLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.ThankYouLabel.Name = "ThankYouLabel";
            this.ThankYouLabel.Size = new System.Drawing.Size(114, 24);
            this.ThankYouLabel.TabIndex = 0;
            this.ThankYouLabel.Text = "Thank you!";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(47, 63);
            this.MessageLabel.MaximumSize = new System.Drawing.Size(300, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(217, 48);
            this.MessageLabel.TabIndex = 1;
            this.MessageLabel.Text = "Your Movie will begin streaming soon!";
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = true;
            this.OkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OkButton.Location = new System.Drawing.Point(124, 127);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 30);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SmilePictureBox
            // 
            this.SmilePictureBox.Image = global::COMP1004_F2016_Assign3_MovieBonanza.Properties.Resources.SmileIcon;
            this.SmilePictureBox.Location = new System.Drawing.Point(167, 12);
            this.SmilePictureBox.Name = "SmilePictureBox";
            this.SmilePictureBox.Size = new System.Drawing.Size(60, 48);
            this.SmilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SmilePictureBox.TabIndex = 2;
            this.SmilePictureBox.TabStop = false;
            // 
            // StreamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 169);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.SmilePictureBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ThankYouLabel);
            this.Name = "StreamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stream Message | Movie Bonanza";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StreamForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.SmilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThankYouLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.PictureBox SmilePictureBox;
        private System.Windows.Forms.Button OkButton;
    }
}