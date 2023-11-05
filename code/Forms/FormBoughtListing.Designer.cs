namespace code.Forms
{
    partial class FormBoughtListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBoughtListing));
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.pictureBoxListingImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(12, 488);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(120, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "$ Price here...";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(13, 463);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 13);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address here...";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeller.Location = new System.Drawing.Point(13, 391);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(95, 13);
            this.lblSeller.TabIndex = 10;
            this.lblSeller.Text = "Seller name here...";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 367);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 24);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name here...";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Location = new System.Drawing.Point(14, 517);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(71, 13);
            this.lblOwner.TabIndex = 11;
            this.lblOwner.Text = "Owner here...";
            // 
            // pictureBoxListingImage
            // 
            this.pictureBoxListingImage.Image = global::code.Properties.Resources._4b860467_ff83_4d33_91d8_887cf9cbe499;
            this.pictureBoxListingImage.Location = new System.Drawing.Point(15, 12);
            this.pictureBoxListingImage.Name = "pictureBoxListingImage";
            this.pictureBoxListingImage.Size = new System.Drawing.Size(417, 343);
            this.pictureBoxListingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxListingImage.TabIndex = 20;
            this.pictureBoxListingImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(16, 416);
            this.lblDescription.MaximumSize = new System.Drawing.Size(414, 35);
            this.lblDescription.Multiline = true;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.ReadOnly = true;
            this.lblDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblDescription.Size = new System.Drawing.Size(414, 35);
            this.lblDescription.TabIndex = 23;
            this.lblDescription.Text = "love include laid movie pair day class explanation brother five bell manufacturin" +
    "g eaten throw desert loss giving buy answer fence better";
            // 
            // FormBoughtListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 546);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBoxListingImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 585);
            this.MinimumSize = new System.Drawing.Size(460, 585);
            this.Name = "FormBoughtListing";
            this.Text = "Назва купленої нерухомості...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.PictureBox pictureBoxListingImage;
        private System.Windows.Forms.TextBox lblDescription;
    }
}