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
            this.formTitle = new code.FormTitle();
            this.buttonAddListing = new code.StyledButton();
            this.buttonDeleteProfile = new code.StyledButton();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(13, 61);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(136, 20);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Ім\'я користувача";
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.Black;
            this.formTitle.Location = new System.Drawing.Point(12, 19);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(108, 26);
            this.formTitle.TabIndex = 2;
            this.formTitle.Text = "Профіль";
            // 
            // buttonAddListing
            // 
            this.buttonAddListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonAddListing.FlatAppearance.BorderSize = 0;
            this.buttonAddListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddListing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAddListing.Location = new System.Drawing.Point(12, 514);
            this.buttonAddListing.Name = "buttonAddListing";
            this.buttonAddListing.Size = new System.Drawing.Size(201, 35);
            this.buttonAddListing.TabIndex = 3;
            this.buttonAddListing.Text = "Додати оголошення";
            this.buttonAddListing.UseVisualStyleBackColor = false;
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.BackColor = System.Drawing.Color.Firebrick;
            this.buttonDeleteProfile.FlatAppearance.BorderSize = 0;
            this.buttonDeleteProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDeleteProfile.Location = new System.Drawing.Point(219, 514);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(201, 35);
            this.buttonDeleteProfile.TabIndex = 3;
            this.buttonDeleteProfile.Text = "Видалити профіль";
            this.buttonDeleteProfile.UseVisualStyleBackColor = false;
            // 
            // FormProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.buttonDeleteProfile);
            this.Controls.Add(this.buttonAddListing);
            this.Controls.Add(this.formTitle);
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
        private FormTitle formTitle;
        private StyledButton buttonAddListing;
        private StyledButton buttonDeleteProfile;
    }
}