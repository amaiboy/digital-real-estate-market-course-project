namespace digital_real_estate_market_course_project;

public partial class mainAppForm : Form
{
    public mainAppForm()
    {
        InitializeComponent();

        this.Size = new Size(1200, 800);
        this.MinimumSize = new Size(1200, 800);
        testLabel.Text = "";
    }

    private void btnDevelopers_Click(object sender, EventArgs e)
    {
        testLabel.Text = "Розробники";
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        testLabel.Text = "Інструкція";
    }

    private void btnMarket_Click(object sender, EventArgs e)
    {
        testLabel.Text = "Ринок";
    }
}
