namespace code
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelFormContainer = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonDevelopers = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonMarket = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonDevelopers);
            this.panelMenu.Controls.Add(this.buttonHelp);
            this.panelMenu.Controls.Add(this.buttonMarket);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelFormContainer
            // 
            this.panelFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormContainer.Location = new System.Drawing.Point(220, 0);
            this.panelFormContainer.Name = "panelFormContainer";
            this.panelFormContainer.Size = new System.Drawing.Size(764, 561);
            this.panelFormContainer.TabIndex = 1;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProfile.Location = new System.Drawing.Point(0, 441);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(220, 60);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Профіль";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSettings.Location = new System.Drawing.Point(0, 501);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(220, 60);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Налаштування";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonDevelopers
            // 
            this.buttonDevelopers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDevelopers.FlatAppearance.BorderSize = 0;
            this.buttonDevelopers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevelopers.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDevelopers.Location = new System.Drawing.Point(0, 120);
            this.buttonDevelopers.Name = "buttonDevelopers";
            this.buttonDevelopers.Size = new System.Drawing.Size(220, 60);
            this.buttonDevelopers.TabIndex = 3;
            this.buttonDevelopers.Text = "Про розробників";
            this.buttonDevelopers.UseVisualStyleBackColor = true;
            this.buttonDevelopers.Click += new System.EventHandler(this.buttonDevelopers_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonHelp.Location = new System.Drawing.Point(0, 60);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(220, 60);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Допомога";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonMarket
            // 
            this.buttonMarket.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMarket.FlatAppearance.BorderSize = 0;
            this.buttonMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarket.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMarket.Location = new System.Drawing.Point(0, 0);
            this.buttonMarket.Name = "buttonMarket";
            this.buttonMarket.Size = new System.Drawing.Size(220, 60);
            this.buttonMarket.TabIndex = 1;
            this.buttonMarket.Text = "Ринок нерухомості";
            this.buttonMarket.UseVisualStyleBackColor = true;
            this.buttonMarket.Click += new System.EventHandler(this.buttonMarket_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelFormContainer);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FormMenu";
            this.Text = "Цифровий ринок нерухомості";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMarket;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonDevelopers;
        private System.Windows.Forms.Panel panelFormContainer;
    }
}

