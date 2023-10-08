namespace digital_real_estate_market_course_project;

partial class mainAppForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(mainAppForm));
        sidebarPanel = new Panel();
        btnMarket = new Button();
        btnHelp = new Button();
        btnDevelopers = new Button();
        contentsPanel = new Panel();
        testLabel = new Label();
        sidebarPanel.SuspendLayout();
        contentsPanel.SuspendLayout();
        SuspendLayout();
        // 
        // sidebarPanel
        // 
        sidebarPanel.BackColor = Color.WhiteSmoke;
        sidebarPanel.Controls.Add(btnMarket);
        sidebarPanel.Controls.Add(btnHelp);
        sidebarPanel.Controls.Add(btnDevelopers);
        sidebarPanel.Dock = DockStyle.Left;
        sidebarPanel.ForeColor = SystemColors.ControlText;
        sidebarPanel.Location = new Point(0, 0);
        sidebarPanel.Name = "sidebarPanel";
        sidebarPanel.Size = new Size(400, 744);
        sidebarPanel.TabIndex = 0;
        // 
        // btnMarket
        // 
        btnMarket.Location = new Point(3, 135);
        btnMarket.Name = "btnMarket";
        btnMarket.Size = new Size(391, 60);
        btnMarket.TabIndex = 2;
        btnMarket.Text = "Ринок нерухомості";
        btnMarket.UseVisualStyleBackColor = true;
        btnMarket.Click += btnMarket_Click;
        // 
        // btnHelp
        // 
        btnHelp.Location = new Point(3, 69);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new Size(391, 60);
        btnHelp.TabIndex = 1;
        btnHelp.Text = "Інструкція з використання";
        btnHelp.UseVisualStyleBackColor = true;
        btnHelp.Click += btnHelp_Click;
        // 
        // btnDevelopers
        // 
        btnDevelopers.Location = new Point(3, 3);
        btnDevelopers.Name = "btnDevelopers";
        btnDevelopers.Size = new Size(391, 60);
        btnDevelopers.TabIndex = 0;
        btnDevelopers.Text = "Інформація про розробників";
        btnDevelopers.UseVisualStyleBackColor = true;
        btnDevelopers.Click += btnDevelopers_Click;
        // 
        // contentsPanel
        // 
        contentsPanel.BackColor = Color.White;
        contentsPanel.Controls.Add(testLabel);
        contentsPanel.Dock = DockStyle.Fill;
        contentsPanel.Location = new Point(400, 0);
        contentsPanel.Name = "contentsPanel";
        contentsPanel.Padding = new Padding(4);
        contentsPanel.Size = new Size(778, 744);
        contentsPanel.TabIndex = 1;
        // 
        // testLabel
        // 
        testLabel.AutoSize = true;
        testLabel.Location = new Point(7, 7);
        testLabel.Name = "testLabel";
        testLabel.Size = new Size(59, 25);
        testLabel.TabIndex = 0;
        testLabel.Text = "label1";
        // 
        // mainAppForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1178, 744);
        Controls.Add(contentsPanel);
        Controls.Add(sidebarPanel);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(1200, 800);
        Name = "mainAppForm";
        Text = "Цифровий ринок нерухомості";
        sidebarPanel.ResumeLayout(false);
        contentsPanel.ResumeLayout(false);
        contentsPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Panel sidebarPanel;
    private Button btnMarket;
    private Button btnHelp;
    private Button btnDevelopers;
    private Panel contentsPanel;
    private Label testLabel;
}
