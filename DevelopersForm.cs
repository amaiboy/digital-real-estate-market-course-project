namespace digital_real_estate_market_course_project;

public partial class DevelopersForm : Form
{
    public DevelopersForm()
    {
        InitializeComponent();
    }

    private void btnDevelopers_Click(object sender, EventArgs e)
    {

    }

    private void btnHelp_Click(object sender, EventArgs e)
    {

    }

    private void btnMarket_Click(object sender, EventArgs e)
    {
        MarketForm marketForm = new MarketForm();
        this.Hide();
        marketForm.Show();
    }
}
