namespace NewsletterTester
{
    partial class MainForm
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
            this.NewsletterUrlComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewsletterSendToComboBox = new System.Windows.Forms.ComboBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.ClearRecentUrlsButton = new System.Windows.Forms.Button();
            this.ClearRecentEmailsButton = new System.Windows.Forms.Button();
            this.SpinnerPictureBox = new System.Windows.Forms.PictureBox();
            this.MessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewsletterUrlComboBox
            // 
            this.NewsletterUrlComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsletterUrlComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NewsletterUrlComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NewsletterUrlComboBox.FormattingEnabled = true;
            this.NewsletterUrlComboBox.Location = new System.Drawing.Point(123, 15);
            this.NewsletterUrlComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.NewsletterUrlComboBox.Name = "NewsletterUrlComboBox";
            this.NewsletterUrlComboBox.Size = new System.Drawing.Size(495, 24);
            this.NewsletterUrlComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Newsletter Url:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Send to e-mail:";
            // 
            // NewsletterSendToComboBox
            // 
            this.NewsletterSendToComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewsletterSendToComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NewsletterSendToComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NewsletterSendToComboBox.FormattingEnabled = true;
            this.NewsletterSendToComboBox.Location = new System.Drawing.Point(123, 48);
            this.NewsletterSendToComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.NewsletterSendToComboBox.Name = "NewsletterSendToComboBox";
            this.NewsletterSendToComboBox.Size = new System.Drawing.Size(495, 24);
            this.NewsletterSendToComboBox.TabIndex = 2;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SendButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendButton.Location = new System.Drawing.Point(563, 111);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(89, 31);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_ClickAsync);
            // 
            // ClearRecentUrlsButton
            // 
            this.ClearRecentUrlsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClearRecentUrlsButton.BackgroundImage = global::NewsletterTester.Resources.Clear;
            this.ClearRecentUrlsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearRecentUrlsButton.Location = new System.Drawing.Point(626, 15);
            this.ClearRecentUrlsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearRecentUrlsButton.Name = "ClearRecentUrlsButton";
            this.ClearRecentUrlsButton.Size = new System.Drawing.Size(24, 26);
            this.ClearRecentUrlsButton.TabIndex = 8;
            this.ClearRecentUrlsButton.UseVisualStyleBackColor = true;
            this.ClearRecentUrlsButton.Click += new System.EventHandler(this.ClearRecentUrlsButton_Click);
            // 
            // ClearRecentEmailsButton
            // 
            this.ClearRecentEmailsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ClearRecentEmailsButton.BackgroundImage = global::NewsletterTester.Resources.Clear;
            this.ClearRecentEmailsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClearRecentEmailsButton.Location = new System.Drawing.Point(626, 48);
            this.ClearRecentEmailsButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClearRecentEmailsButton.Name = "ClearRecentEmailsButton";
            this.ClearRecentEmailsButton.Size = new System.Drawing.Size(24, 26);
            this.ClearRecentEmailsButton.TabIndex = 7;
            this.ClearRecentEmailsButton.UseVisualStyleBackColor = true;
            this.ClearRecentEmailsButton.Click += new System.EventHandler(this.ClearRecentEmailsButton_Click);
            // 
            // SpinnerPictureBox
            // 
            this.SpinnerPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SpinnerPictureBox.Location = new System.Drawing.Point(218, 111);
            this.SpinnerPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.SpinnerPictureBox.Name = "SpinnerPictureBox";
            this.SpinnerPictureBox.Size = new System.Drawing.Size(32, 30);
            this.SpinnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SpinnerPictureBox.TabIndex = 6;
            this.SpinnerPictureBox.TabStop = false;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(258, 118);
            this.MessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(0, 16);
            this.MessageLabel.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 165);
            this.Controls.Add(this.ClearRecentUrlsButton);
            this.Controls.Add(this.ClearRecentEmailsButton);
            this.Controls.Add(this.SpinnerPictureBox);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NewsletterSendToComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewsletterUrlComboBox);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Newsletter Tester";
            ((System.ComponentModel.ISupportInitialize)(this.SpinnerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox NewsletterUrlComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NewsletterSendToComboBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.PictureBox SpinnerPictureBox;
        private System.Windows.Forms.Button ClearRecentEmailsButton;
        private System.Windows.Forms.Button ClearRecentUrlsButton;
        private System.Windows.Forms.Label MessageLabel;
    }
}

