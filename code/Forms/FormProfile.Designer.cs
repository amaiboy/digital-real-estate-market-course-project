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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formTitle = new code.FormTitle();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridViewBoughtListings = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddedListings = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new code.StyledButton();
            this.btnAddListing = new code.StyledButton();
            this.btnRefreshBoughtListings = new code.StyledButton();
            this.btnClearBoughtListings = new code.StyledButton();
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
            this.pnlMainContainer.Controls.Add(this.btnClearBoughtListings);
            this.pnlMainContainer.Controls.Add(this.btnRefreshBoughtListings);
            this.pnlMainContainer.Controls.Add(this.btnAddListing);
            this.pnlMainContainer.Controls.Add(this.btnSaveChanges);
            this.pnlMainContainer.Controls.Add(this.dataGridViewAddedListings);
            this.pnlMainContainer.Controls.Add(this.dataGridViewBoughtListings);
            this.pnlMainContainer.Controls.Add(this.textBox3);
            this.pnlMainContainer.Controls.Add(this.textBox2);
            this.pnlMainContainer.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(739, 22);
            this.textBox1.TabIndex = 4;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(739, 22);
            this.textBox2.TabIndex = 4;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(739, 22);
            this.textBox3.TabIndex = 4;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoughtListings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBoughtListings.ColumnHeadersHeight = 35;
            this.dataGridViewBoughtListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBoughtListings.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBoughtListings.EnableHeadersVisualStyles = false;
            this.dataGridViewBoughtListings.Location = new System.Drawing.Point(17, 299);
            this.dataGridViewBoughtListings.Name = "dataGridViewBoughtListings";
            this.dataGridViewBoughtListings.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoughtListings.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddedListings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAddedListings.ColumnHeadersHeight = 35;
            this.dataGridViewAddedListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddedListings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAddedListings.EnableHeadersVisualStyles = false;
            this.dataGridViewAddedListings.Location = new System.Drawing.Point(396, 299);
            this.dataGridViewAddedListings.Name = "dataGridViewAddedListings";
            this.dataGridViewAddedListings.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddedListings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridView dataGridViewAddedListings;
        private System.Windows.Forms.DataGridView dataGridViewBoughtListings;
        private StyledButton btnSaveChanges;
        private StyledButton btnAddListing;
        private StyledButton btnClearBoughtListings;
        private StyledButton btnRefreshBoughtListings;
    }
}