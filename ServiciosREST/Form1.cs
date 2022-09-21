using System.Net.Http.Json;

namespace ServiciosREST;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
        HttpClient client = new HttpClient();
        var result = await client.GetFromJsonAsync<List<Product>>("http://localhost:3000/api/products");
        dataGridView1.DataSource = result;
    }
}
