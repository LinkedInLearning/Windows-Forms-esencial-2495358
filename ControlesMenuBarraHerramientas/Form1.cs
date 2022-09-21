namespace ControlesMenuBarraHerramientas;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hola, esta es mi aplicación");
    }

    private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var archivos = Directory.EnumerateFiles(@"c:\curso\folder");
        foreach (var item in archivos)
        {
            listBox1.Items.Add(item);
        }
        toolStripStatusLabel1.Text = archivos.Count().ToString();
    }

    private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem != null)
        {
            File.Delete(listBox1.SelectedItem.ToString());
        }
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        listBox1.Items.Clear();
        var archivos = Directory.EnumerateFiles(@"c:\curso\folder");
        foreach (var item in archivos)
        {
            listBox1.Items.Add(item);
        }

    }
}