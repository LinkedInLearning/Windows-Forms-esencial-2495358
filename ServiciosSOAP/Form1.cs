namespace ServiciosSOAP;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.CountryInfoServiceSoapTypeClient
            client = new ServiceReference1
            .CountryInfoServiceSoapTypeClient(ServiceReference1.CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);

        var all = client.FullCountryInfoAllCountries();
        dataGridView1.DataSource = all;
    }
}
