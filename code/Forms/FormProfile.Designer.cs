namespace code.Forms
{
    partial class FormProfile
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonAddListing = new System.Windows.Forms.Button();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(12, 9);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(152, 20);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Ім\'я користувача";
            // 
            // buttonAddListing
            // 
            this.buttonAddListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonAddListing.FlatAppearance.BorderSize = 0;
            this.buttonAddListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddListing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddListing.Location = new System.Drawing.Point(12, 510);
            this.buttonAddListing.Name = "buttonAddListing";
            this.buttonAddListing.Size = new System.Drawing.Size(187, 39);
            this.buttonAddListing.TabIndex = 1;
            this.buttonAddListing.Text = "Додати оголошення";
            this.buttonAddListing.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonDeleteProfile.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteProfile.Location = new System.Drawing.Point(215, 510);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(187, 39);
            this.buttonDeleteProfile.TabIndex = 1;
            this.buttonDeleteProfile.Text = "Видалити профіль";
            this.buttonDeleteProfile.UseVisualStyleBackColor = false;
            // 
            // FormProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.buttonDeleteProfile);
            this.Controls.Add(this.buttonAddListing);
            this.Controls.Add(this.labelUserName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(784, 600);
            this.MinimumSize = new System.Drawing.Size(784, 600);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonAddListing;
        private System.Windows.Forms.Button buttonDeleteProfile;
    }
}