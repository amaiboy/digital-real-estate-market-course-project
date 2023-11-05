namespace code.Forms
{
    partial class FormBuyListing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyListing));
            this.btnBuy = new code.StyledButton();
            this.btnClose = new code.StyledButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSeller = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBoxListingImage = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuy.Location = new System.Drawing.Point(12, 533);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(120, 30);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Придбати";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(138, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(11, 375);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name here...";
            // 
            // lblSeller
            // 
            this.lblSeller.AutoSize = true;
            this.lblSeller.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeller.Location = new System.Drawing.Point(12, 399);
            this.lblSeller.Name = "lblSeller";
            this.lblSeller.Size = new System.Drawing.Size(95, 13);
            this.lblSeller.TabIndex = 3;
            this.lblSeller.Text = "Seller name here...";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(12, 471);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(88, 15);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address here...";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(11, 496);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(120, 20);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "$ Price here...";
            // 
            // pictureBoxListingImage
            // 
            this.pictureBoxListingImage.Image = global::code.Properties.Resources._4b860467_ff83_4d33_91d8_887cf9cbe499;
            this.pictureBoxListingImage.Location = new System.Drawing.Point(15, 12);
            this.pictureBoxListingImage.Name = "pictureBoxListingImage";
            this.pictureBoxListingImage.Size = new System.Drawing.Size(417, 343);
            this.pictureBoxListingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxListingImage.TabIndex = 21;
            this.pictureBoxListingImage.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.Control;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(15, 424);
            this.lblDescription.MaximumSize = new System.Drawing.Size(414, 35);
            this.lblDescription.Multiline = true;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.ReadOnly = true;
            this.lblDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblDescription.Size = new System.Drawing.Size(414, 35);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "love include laid movie pair day class explanation brother five bell manufacturin" +
    "g eaten throw desert loss giving buy answer fence better";
            // 
            // FormBuyListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 581);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBoxListingImage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSeller);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBuy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(460, 620);
            this.MinimumSize = new System.Drawing.Size(460, 620);
            this.Name = "FormBuyListing";
            this.Text = "Назва нерухомості...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxListingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StyledButton btnBuy;
        private StyledButton btnClose;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSeller;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBoxListingImage;
        private System.Windows.Forms.TextBox lblDescription;
    }
}