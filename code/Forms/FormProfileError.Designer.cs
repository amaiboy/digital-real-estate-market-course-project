namespace code.Forms
{
    partial class FormProfileError
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
            this.labelWelcomeMessage = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelRandomTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcomeMessage
            // 
            this.labelWelcomeMessage.AutoSize = true;
            this.labelWelcomeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomeMessage.Location = new System.Drawing.Point(89, 275);
            this.labelWelcomeMessage.Name = "labelWelcomeMessage";
            this.labelWelcomeMessage.Size = new System.Drawing.Size(607, 37);
            this.labelWelcomeMessage.TabIndex = 4;
            this.labelWelcomeMessage.Text = "Йой... Здається Вам не вдалося увійти";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::code.Properties.Resources.sad;
            this.logoPictureBox.Location = new System.Drawing.Point(291, 92);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(179, 165);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPictureBox.TabIndex = 3;
            this.logoPictureBox.TabStop = false;
            // 
            // labelRandomTip
            // 
            this.labelRandomTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRandomTip.Location = new System.Drawing.Point(244, 334);
            this.labelRandomTip.Name = "labelRandomTip";
            this.labelRandomTip.Size = new System.Drawing.Size(290, 98);
            this.labelRandomTip.TabIndex = 5;
            this.labelRandomTip.Text = "Ви можете спробувати наступного разу. Ми перепрошуємо за незручності.";
            this.labelRandomTip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormProfileError
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.labelRandomTip);
            this.Controls.Add(this.labelWelcomeMessage);
            this.Controls.Add(this.logoPictureBox);
            this.MaximumSize = new System.Drawing.Size(784, 600);
            this.MinimumSize = new System.Drawing.Size(784, 600);
            this.Name = "FormProfileError";
            this.Text = "FormProfileError";
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcomeMessage;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelRandomTip;
    }
}