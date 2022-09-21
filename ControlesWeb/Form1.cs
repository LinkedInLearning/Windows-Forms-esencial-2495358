namespace ControlesWeb;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        webView21.Source = new Uri(textBox1.Text);
    }
}
