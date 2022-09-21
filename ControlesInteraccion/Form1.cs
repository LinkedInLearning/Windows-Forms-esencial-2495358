namespace ControlesInteraccion;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Clic del botón");
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        MessageBox.Show("CheckedChanged");
    }
}
