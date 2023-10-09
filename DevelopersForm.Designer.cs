namespace digital_real_estate_market_course_project;

partial class DevelopersForm
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(DevelopersForm));
        sidebarPanel = new Panel();
        btnMarket = new Button();
        btnHelp = new Button();
        btnDevelopers = new Button();
        contentsPanel = new Panel();
        paragraphAlgorithms = new ParagraphLabel();
        paragraphExceptions = new ParagraphLabel();
        paragraphData = new ParagraphLabel();
        paragraphInterface = new ParagraphLabel();
        paragraphTeamLead = new ParagraphLabel();
        paragraphIntroduction = new ParagraphLabel();
        headingAppName = new Label();
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
        sidebarPanel.Size = new Size(318, 744);
        sidebarPanel.TabIndex = 0;
        // 
        // btnMarket
        // 
        btnMarket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        btnMarket.Location = new Point(3, 135);
        btnMarket.Name = "btnMarket";
        btnMarket.Size = new Size(308, 60);
        btnMarket.TabIndex = 2;
        btnMarket.Text = "Ринок нерухомості";
        btnMarket.UseVisualStyleBackColor = true;
        btnMarket.Click += btnMarket_Click;
        // 
        // btnHelp
        // 
        btnHelp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        btnHelp.Location = new Point(3, 69);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new Size(308, 60);
        btnHelp.TabIndex = 1;
        btnHelp.Text = "Інструкція з використання";
        btnHelp.UseVisualStyleBackColor = true;
        btnHelp.Click += btnHelp_Click;
        // 
        // btnDevelopers
        // 
        btnDevelopers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        btnDevelopers.Location = new Point(3, 3);
        btnDevelopers.Name = "btnDevelopers";
        btnDevelopers.Size = new Size(308, 60);
        btnDevelopers.TabIndex = 0;
        btnDevelopers.Text = "Інформація про розробників";
        btnDevelopers.UseVisualStyleBackColor = true;
        btnDevelopers.Click += btnDevelopers_Click;
        // 
        // contentsPanel
        // 
        contentsPanel.BackColor = Color.White;
        contentsPanel.Controls.Add(paragraphAlgorithms);
        contentsPanel.Controls.Add(paragraphExceptions);
        contentsPanel.Controls.Add(paragraphData);
        contentsPanel.Controls.Add(paragraphInterface);
        contentsPanel.Controls.Add(paragraphTeamLead);
        contentsPanel.Controls.Add(paragraphIntroduction);
        contentsPanel.Controls.Add(headingAppName);
        contentsPanel.Dock = DockStyle.Fill;
        contentsPanel.Location = new Point(318, 0);
        contentsPanel.Name = "contentsPanel";
        contentsPanel.Size = new Size(860, 744);
        contentsPanel.TabIndex = 1;
        // 
        // paragraphAlgorithms
        // 
        paragraphAlgorithms.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        paragraphAlgorithms.Location = new Point(9, 169);
        paragraphAlgorithms.Name = "paragraphAlgorithms";
        paragraphAlgorithms.Size = new Size(842, 35);
        paragraphAlgorithms.TabIndex = 1;
        paragraphAlgorithms.Text = "- Коваленко Владислав - реалізація алгоритмів";
        // 
        // paragraphExceptions
        // 
        paragraphExceptions.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        paragraphExceptions.Location = new Point(9, 239);
        paragraphExceptions.Name = "paragraphExceptions";
        paragraphExceptions.Size = new Size(842, 35);
        paragraphExceptions.TabIndex = 1;
        paragraphExceptions.Text = "- Васильєв Максим - обробка виключних ситуацій";
        // 
        // paragraphData
        // 
        paragraphData.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        paragraphData.Location = new Point(9, 204);
        paragraphData.Name = "paragraphData";
        paragraphData.Size = new Size(842, 35);
        paragraphData.TabIndex = 1;
        paragraphData.Text = "- Барабаш Антон - робота з даними";
        // 
        // paragraphInterface
        // 
        paragraphInterface.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        paragraphInterface.Location = new Point(9, 274);
        paragraphInterface.Name = "paragraphInterface";
        paragraphInterface.Size = new Size(842, 35);
        paragraphInterface.TabIndex = 1;
        paragraphInterface.Text = "- Онищенко Олег - розробка інтерфейсу та дизайн";
        // 
        // paragraphTeamLead
        // 
        paragraphTeamLead.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        paragraphTeamLead.Location = new Point(9, 134);
        paragraphTeamLead.Name = "paragraphTeamLead";
        paragraphTeamLead.Size = new Size(842, 35);
        paragraphTeamLead.TabIndex = 1;
        paragraphTeamLead.Text = "- Коганті Кирило - архітектура та класи - Team Lead";
        // 
        // paragraphIntroduction
        // 
        paragraphIntroduction.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        paragraphIntroduction.Location = new Point(9, 60);
        paragraphIntroduction.Name = "paragraphIntroduction";
        paragraphIntroduction.Size = new Size(842, 68);
        paragraphIntroduction.TabIndex = 1;
        paragraphIntroduction.Text = "Цей додаток розробила команда з групи КНТ-122. Нижче наведені всі учасники команди та їхні відповідальності.";
        // 
        // headingAppName
        // 
        headingAppName.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
        headingAppName.Location = new Point(6, 9);
        headingAppName.Name = "headingAppName";
        headingAppName.Size = new Size(375, 38);
        headingAppName.TabIndex = 0;
        headingAppName.Text = "Розробники застосунку";
        // 
        // DevelopersForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1178, 744);
        Controls.Add(contentsPanel);
        Controls.Add(sidebarPanel);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(1200, 800);
        Name = "DevelopersForm";
        Text = "Інформація про розробників - Цифровий ринок нерухомості";
        sidebarPanel.ResumeLayout(false);
        contentsPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Panel sidebarPanel;
    private Button btnMarket;
    private Button btnHelp;
    private Button btnDevelopers;
    private Panel contentsPanel;
    private Label headingAppName;
    private ParagraphLabel paragraphIntroduction;
    private ParagraphLabel paragraphTeamLead;
    private ParagraphLabel paragraphInterface;
    private ParagraphLabel paragraphAlgorithms;
    private ParagraphLabel paragraphExceptions;
    private ParagraphLabel paragraphData;
}
