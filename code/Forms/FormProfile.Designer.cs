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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formTitle = new code.FormTitle();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.dataGridViewBoughtListings = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddedListings = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new code.StyledButton();
            this.btnAddListing = new code.StyledButton();
            this.btnRefreshBoughtListings = new code.StyledButton();
            this.btnClearBoughtListings = new code.StyledButton();
            this.btnTogglePasswordVisibility = new code.StyledButton();
            this.pnlMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoughtListings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedListings)).BeginInit();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.Black;
            this.formTitle.Location = new System.Drawing.Point(12, 24);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(108, 26);
            this.formTitle.TabIndex = 2;
            this.formTitle.Text = "Профіль";
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.btnTogglePasswordVisibility);
            this.pnlMainContainer.Controls.Add(this.btnClearBoughtListings);
            this.pnlMainContainer.Controls.Add(this.btnRefreshBoughtListings);
            this.pnlMainContainer.Controls.Add(this.btnAddListing);
            this.pnlMainContainer.Controls.Add(this.btnSaveChanges);
            this.pnlMainContainer.Controls.Add(this.dataGridViewAddedListings);
            this.pnlMainContainer.Controls.Add(this.dataGridViewBoughtListings);
            this.pnlMainContainer.Controls.Add(this.txtPassword);
            this.pnlMainContainer.Controls.Add(this.txtEmail);
            this.pnlMainContainer.Controls.Add(this.txtUsername);
            this.pnlMainContainer.Controls.Add(this.lblPassword);
            this.pnlMainContainer.Controls.Add(this.lblEmail);
            this.pnlMainContainer.Controls.Add(this.lblUsername);
            this.pnlMainContainer.Controls.Add(this.formTitle);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(768, 561);
            this.pnlMainContainer.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 74);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 16);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Ім\'я користувача";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(17, 93);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(739, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 128);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Електронна пошта";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(739, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 201);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(574, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // dataGridViewBoughtListings
            // 
            this.dataGridViewBoughtListings.AllowUserToAddRows = false;
            this.dataGridViewBoughtListings.AllowUserToDeleteRows = false;
            this.dataGridViewBoughtListings.AllowUserToOrderColumns = true;
            this.dataGridViewBoughtListings.AllowUserToResizeRows = false;
            this.dataGridViewBoughtListings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBoughtListings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBoughtListings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBoughtListings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewBoughtListings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoughtListings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewBoughtListings.ColumnHeadersHeight = 35;
            this.dataGridViewBoughtListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBoughtListings.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewBoughtListings.EnableHeadersVisualStyles = false;
            this.dataGridViewBoughtListings.Location = new System.Drawing.Point(17, 299);
            this.dataGridViewBoughtListings.Name = "dataGridViewBoughtListings";
            this.dataGridViewBoughtListings.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoughtListings.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewBoughtListings.RowHeadersVisible = false;
            this.dataGridViewBoughtListings.RowTemplate.Height = 50;
            this.dataGridViewBoughtListings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBoughtListings.Size = new System.Drawing.Size(360, 209);
            this.dataGridViewBoughtListings.TabIndex = 5;
            // 
            // dataGridViewAddedListings
            // 
            this.dataGridViewAddedListings.AllowUserToAddRows = false;
            this.dataGridViewAddedListings.AllowUserToDeleteRows = false;
            this.dataGridViewAddedListings.AllowUserToOrderColumns = true;
            this.dataGridViewAddedListings.AllowUserToResizeRows = false;
            this.dataGridViewAddedListings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddedListings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAddedListings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAddedListings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewAddedListings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddedListings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewAddedListings.ColumnHeadersHeight = 35;
            this.dataGridViewAddedListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddedListings.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewAddedListings.EnableHeadersVisualStyles = false;
            this.dataGridViewAddedListings.Location = new System.Drawing.Point(396, 299);
            this.dataGridViewAddedListings.Name = "dataGridViewAddedListings";
            this.dataGridViewAddedListings.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddedListings.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewAddedListings.RowHeadersVisible = false;
            this.dataGridViewAddedListings.RowTemplate.Height = 50;
            this.dataGridViewAddedListings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddedListings.Size = new System.Drawing.Size(360, 209);
            this.dataGridViewAddedListings.TabIndex = 5;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveChanges.Location = new System.Drawing.Point(17, 240);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(175, 35);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Зберегти зміни";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnAddListing
            // 
            this.btnAddListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddListing.FlatAppearance.BorderSize = 0;
            this.btnAddListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddListing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddListing.Location = new System.Drawing.Point(396, 514);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(360, 35);
            this.btnAddListing.TabIndex = 6;
            this.btnAddListing.Text = "Додати оголошення";
            this.btnAddListing.UseVisualStyleBackColor = false;
            // 
            // btnRefreshBoughtListings
            // 
            this.btnRefreshBoughtListings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRefreshBoughtListings.FlatAppearance.BorderSize = 0;
            this.btnRefreshBoughtListings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBoughtListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBoughtListings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshBoughtListings.Location = new System.Drawing.Point(17, 514);
            this.btnRefreshBoughtListings.Name = "btnRefreshBoughtListings";
            this.btnRefreshBoughtListings.Size = new System.Drawing.Size(175, 35);
            this.btnRefreshBoughtListings.TabIndex = 6;
            this.btnRefreshBoughtListings.Text = "Оновити список";
            this.btnRefreshBoughtListings.UseVisualStyleBackColor = false;
            // 
            // btnClearBoughtListings
            // 
            this.btnClearBoughtListings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClearBoughtListings.FlatAppearance.BorderSize = 0;
            this.btnClearBoughtListings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBoughtListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBoughtListings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearBoughtListings.Location = new System.Drawing.Point(202, 514);
            this.btnClearBoughtListings.Name = "btnClearBoughtListings";
            this.btnClearBoughtListings.Size = new System.Drawing.Size(175, 35);
            this.btnClearBoughtListings.TabIndex = 6;
            this.btnClearBoughtListings.Text = "Очистити список";
            this.btnClearBoughtListings.UseVisualStyleBackColor = false;
            // 
            // btnTogglePasswordVisibility
            // 
            this.btnTogglePasswordVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnTogglePasswordVisibility.FlatAppearance.BorderSize = 0;
            this.btnTogglePasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePasswordVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTogglePasswordVisibility.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTogglePasswordVisibility.Location = new System.Drawing.Point(597, 201);
            this.btnTogglePasswordVisibility.Name = "btnTogglePasswordVisibility";
            this.btnTogglePasswordVisibility.Size = new System.Drawing.Size(159, 22);
            this.btnTogglePasswordVisibility.TabIndex = 7;
            this.btnTogglePasswordVisibility.Text = "Показати пароль";
            this.btnTogglePasswordVisibility.UseVisualStyleBackColor = false;
            this.btnTogglePasswordVisibility.Click += new System.EventHandler(this.btnTogglePasswordVisibility_Click);
            // 
            // FormProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(768, 561);
            this.Controls.Add(this.pnlMainContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(784, 600);
            this.MinimumSize = new System.Drawing.Size(784, 600);
            this.Name = "FormProfile";
            this.Text = "FormProfile";
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoughtListings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedListings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FormTitle formTitle;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dataGridViewAddedListings;
        private System.Windows.Forms.DataGridView dataGridViewBoughtListings;
        private StyledButton btnSaveChanges;
        private StyledButton btnAddListing;
        private StyledButton btnClearBoughtListings;
        private StyledButton btnRefreshBoughtListings;
        private StyledButton btnTogglePasswordVisibility;
    }
}