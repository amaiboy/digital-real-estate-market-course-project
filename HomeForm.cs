namespace digital_real_estate_market_course_project;

public partial class mainAppForm : Form
{
    public mainAppForm()
    {
        InitializeComponent();

        this.Size = new Size(1200, 800);
        this.MinimumSize = new Size(1200, 800);
        testLabel.Text = "";

        // TODO: Add a form on load that will show some navigation and maybe program info
        // TODO: Add three forms for the three sections and change the form based on button click on sidebar
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
