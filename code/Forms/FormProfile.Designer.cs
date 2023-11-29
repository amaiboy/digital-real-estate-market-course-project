using code.Classes;
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formTitle = new code.MainTitle();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.btnExit = new code.StyledButton();
            this.deleteAdvertismentButton = new code.StyledButton();
            this.lblEmptyAddedListings = new System.Windows.Forms.Label();
            this.lblEmptyBoughtListings = new System.Windows.Forms.Label();
            this.lblAddedListings = new System.Windows.Forms.Label();
            this.lblBoughtListings = new System.Windows.Forms.Label();
            this.btnTogglePasswordVisibility = new code.StyledButton();
            this.btnClearBoughtListings = new code.StyledButton();
            this.btnRefreshBoughtListings = new code.StyledButton();
            this.btnAddListing = new code.StyledButton();
            this.btnSaveChanges = new code.StyledButton();
            this.dataGridViewAddedListings = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewBoughtListings = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlMainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedListings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoughtListings)).BeginInit();
            this.SuspendLayout();
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.Black;
            this.formTitle.Location = new System.Drawing.Point(12, 24);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(281, 26);
            this.formTitle.TabIndex = 2;
            this.formTitle.Text = "Профіль користувача ...";
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Controls.Add(this.btnExit);
            this.pnlMainContainer.Controls.Add(this.deleteAdvertismentButton);
            this.pnlMainContainer.Controls.Add(this.lblEmptyAddedListings);
            this.pnlMainContainer.Controls.Add(this.lblEmptyBoughtListings);
            this.pnlMainContainer.Controls.Add(this.lblAddedListings);
            this.pnlMainContainer.Controls.Add(this.lblBoughtListings);
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkRed;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(659, 228);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 35);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Вийти";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // deleteAdvertismentButton
            // 
            this.deleteAdvertismentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.deleteAdvertismentButton.FlatAppearance.BorderSize = 0;
            this.deleteAdvertismentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAdvertismentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAdvertismentButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteAdvertismentButton.Location = new System.Drawing.Point(582, 523);
            this.deleteAdvertismentButton.Name = "deleteAdvertismentButton";
            this.deleteAdvertismentButton.Size = new System.Drawing.Size(165, 26);
            this.deleteAdvertismentButton.TabIndex = 10;
            this.deleteAdvertismentButton.Text = "Видалити оголошення";
            this.deleteAdvertismentButton.UseVisualStyleBackColor = false;
            this.deleteAdvertismentButton.Click += new System.EventHandler(this.deleteAdvertismentButton_Click);
            // 
            // lblEmptyAddedListings
            // 
            this.lblEmptyAddedListings.AutoSize = true;
            this.lblEmptyAddedListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyAddedListings.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmptyAddedListings.Location = new System.Drawing.Point(428, 417);
            this.lblEmptyAddedListings.Name = "lblEmptyAddedListings";
            this.lblEmptyAddedListings.Size = new System.Drawing.Size(301, 16);
            this.lblEmptyAddedListings.TabIndex = 9;
            this.lblEmptyAddedListings.Text = "Список доданої нерухомості порожній...";
            // 
            // lblEmptyBoughtListings
            // 
            this.lblEmptyBoughtListings.AutoSize = true;
            this.lblEmptyBoughtListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyBoughtListings.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmptyBoughtListings.Location = new System.Drawing.Point(43, 417);
            this.lblEmptyBoughtListings.Name = "lblEmptyBoughtListings";
            this.lblEmptyBoughtListings.Size = new System.Drawing.Size(309, 16);
            this.lblEmptyBoughtListings.TabIndex = 9;
            this.lblEmptyBoughtListings.Text = "Список купленої нерухомості порожній...";
            // 
            // lblAddedListings
            // 
            this.lblAddedListings.AutoSize = true;
            this.lblAddedListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedListings.Location = new System.Drawing.Point(393, 286);
            this.lblAddedListings.Name = "lblAddedListings";
            this.lblAddedListings.Size = new System.Drawing.Size(168, 18);
            this.lblAddedListings.TabIndex = 8;
            this.lblAddedListings.Text = "Додана нерухомість";
            // 
            // lblBoughtListings
            // 
            this.lblBoughtListings.AutoSize = true;
            this.lblBoughtListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoughtListings.Location = new System.Drawing.Point(14, 286);
            this.lblBoughtListings.Name = "lblBoughtListings";
            this.lblBoughtListings.Size = new System.Drawing.Size(173, 18);
            this.lblBoughtListings.TabIndex = 8;
            this.lblBoughtListings.Text = "Куплена нерухомість";
            // 
            // btnTogglePasswordVisibility
            // 
            this.btnTogglePasswordVisibility.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnTogglePasswordVisibility.FlatAppearance.BorderSize = 0;
            this.btnTogglePasswordVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePasswordVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTogglePasswordVisibility.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTogglePasswordVisibility.Location = new System.Drawing.Point(597, 195);
            this.btnTogglePasswordVisibility.Name = "btnTogglePasswordVisibility";
            this.btnTogglePasswordVisibility.Size = new System.Drawing.Size(159, 22);
            this.btnTogglePasswordVisibility.TabIndex = 7;
            this.btnTogglePasswordVisibility.Text = "Показати пароль";
            this.btnTogglePasswordVisibility.UseVisualStyleBackColor = false;
            this.btnTogglePasswordVisibility.Click += new System.EventHandler(this.btnTogglePasswordVisibility_Click);
            // 
            // btnClearBoughtListings
            // 
            this.btnClearBoughtListings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClearBoughtListings.FlatAppearance.BorderSize = 0;
            this.btnClearBoughtListings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearBoughtListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBoughtListings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearBoughtListings.Location = new System.Drawing.Point(202, 523);
            this.btnClearBoughtListings.Name = "btnClearBoughtListings";
            this.btnClearBoughtListings.Size = new System.Drawing.Size(175, 26);
            this.btnClearBoughtListings.TabIndex = 6;
            this.btnClearBoughtListings.Text = "Очистити список";
            this.btnClearBoughtListings.UseVisualStyleBackColor = false;
            this.btnClearBoughtListings.Click += new System.EventHandler(this.btnClearBoughtListings_Click);
            // 
            // btnRefreshBoughtListings
            // 
            this.btnRefreshBoughtListings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRefreshBoughtListings.FlatAppearance.BorderSize = 0;
            this.btnRefreshBoughtListings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBoughtListings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBoughtListings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefreshBoughtListings.Location = new System.Drawing.Point(17, 523);
            this.btnRefreshBoughtListings.Name = "btnRefreshBoughtListings";
            this.btnRefreshBoughtListings.Size = new System.Drawing.Size(175, 26);
            this.btnRefreshBoughtListings.TabIndex = 6;
            this.btnRefreshBoughtListings.Text = "Оновити список";
            this.btnRefreshBoughtListings.UseVisualStyleBackColor = false;
            this.btnRefreshBoughtListings.Click += new System.EventHandler(this.btnRefreshBoughtListings_Click);
            // 
            // btnAddListing
            // 
            this.btnAddListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddListing.FlatAppearance.BorderSize = 0;
            this.btnAddListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddListing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddListing.Location = new System.Drawing.Point(408, 523);
            this.btnAddListing.Name = "btnAddListing";
            this.btnAddListing.Size = new System.Drawing.Size(165, 26);
            this.btnAddListing.TabIndex = 6;
            this.btnAddListing.Text = "Додати оголошення";
            this.btnAddListing.UseVisualStyleBackColor = false;
            this.btnAddListing.Click += new System.EventHandler(this.btnAddListing_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveChanges.Location = new System.Drawing.Point(17, 228);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(175, 35);
            this.btnSaveChanges.TabIndex = 6;
            this.btnSaveChanges.Text = "Зберегти зміни";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // dataGridViewAddedListings
            // 
            this.dataGridViewAddedListings.AllowUserToAddRows = false;
            this.dataGridViewAddedListings.AllowUserToDeleteRows = false;
            this.dataGridViewAddedListings.AllowUserToOrderColumns = true;
            this.dataGridViewAddedListings.AllowUserToResizeRows = false;
            this.dataGridViewAddedListings.AutoGenerateColumns = false;
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
            this.dataGridViewAddedListings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.addressDataGridViewTextBoxColumn1,
            this.sellerDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dataGridViewAddedListings.DataSource = this.listingBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddedListings.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAddedListings.EnableHeadersVisualStyles = false;
            this.dataGridViewAddedListings.Location = new System.Drawing.Point(396, 312);
            this.dataGridViewAddedListings.Name = "dataGridViewAddedListings";
            this.dataGridViewAddedListings.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddedListings.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAddedListings.RowHeadersVisible = false;
            this.dataGridViewAddedListings.RowTemplate.Height = 50;
            this.dataGridViewAddedListings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAddedListings.Size = new System.Drawing.Size(360, 205);
            this.dataGridViewAddedListings.TabIndex = 5;
            this.dataGridViewAddedListings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddedListings_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.FillWeight = 150F;
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.FillWeight = 1F;
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn1
            // 
            this.addressDataGridViewTextBoxColumn1.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn1.FillWeight = 1F;
            this.addressDataGridViewTextBoxColumn1.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn1.Name = "addressDataGridViewTextBoxColumn1";
            this.addressDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sellerDataGridViewTextBoxColumn1
            // 
            this.sellerDataGridViewTextBoxColumn1.DataPropertyName = "Seller";
            this.sellerDataGridViewTextBoxColumn1.HeaderText = "Продавець";
            this.sellerDataGridViewTextBoxColumn1.Name = "sellerDataGridViewTextBoxColumn1";
            this.sellerDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = "0";
            this.priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.priceDataGridViewTextBoxColumn1.FillWeight = 70F;
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // listingBindingSource
            // 
            this.listingBindingSource.DataSource = typeof(code.Classes.Advertisement);
            // 
            // dataGridViewBoughtListings
            // 
            this.dataGridViewBoughtListings.AllowUserToAddRows = false;
            this.dataGridViewBoughtListings.AllowUserToDeleteRows = false;
            this.dataGridViewBoughtListings.AllowUserToOrderColumns = true;
            this.dataGridViewBoughtListings.AllowUserToResizeRows = false;
            this.dataGridViewBoughtListings.AutoGenerateColumns = false;
            this.dataGridViewBoughtListings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBoughtListings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBoughtListings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBoughtListings.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewBoughtListings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoughtListings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBoughtListings.ColumnHeadersHeight = 35;
            this.dataGridViewBoughtListings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBoughtListings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.sellerDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridViewBoughtListings.DataSource = this.listingBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBoughtListings.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBoughtListings.EnableHeadersVisualStyles = false;
            this.dataGridViewBoughtListings.Location = new System.Drawing.Point(17, 312);
            this.dataGridViewBoughtListings.Name = "dataGridViewBoughtListings";
            this.dataGridViewBoughtListings.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBoughtListings.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBoughtListings.RowHeadersVisible = false;
            this.dataGridViewBoughtListings.RowTemplate.Height = 50;
            this.dataGridViewBoughtListings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBoughtListings.Size = new System.Drawing.Size(360, 205);
            this.dataGridViewBoughtListings.TabIndex = 5;
            this.dataGridViewBoughtListings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBoughtListings_CellDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 150F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 1F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.FillWeight = 1F;
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "Seller";
            this.sellerDataGridViewTextBoxColumn.HeaderText = "Продавець";
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            this.sellerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C0";
            dataGridViewCellStyle6.NullValue = "0";
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.priceDataGridViewTextBoxColumn.FillWeight = 70F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 195);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(574, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 141);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(739, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(17, 87);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(739, 22);
            this.txtUsername.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 176);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 16);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Змінити пароль";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(131, 16);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Електронна пошта";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 68);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(117, 16);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Ім\'я користувача";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddedListings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoughtListings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MainTitle formTitle;
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
        private System.Windows.Forms.BindingSource listingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblAddedListings;
        private System.Windows.Forms.Label lblBoughtListings;
        private System.Windows.Forms.Label lblEmptyBoughtListings;
        private System.Windows.Forms.Label lblEmptyAddedListings;
        private StyledButton deleteAdvertismentButton;
        private StyledButton btnExit;
    }
}