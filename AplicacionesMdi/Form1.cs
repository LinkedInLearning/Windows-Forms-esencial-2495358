namespace AplicacionesMdi;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void abrirVentanaToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var nuevoForm2 = new Form2();
        nuevoForm2.MdiParent = this;
        nuevoForm2.Show();
        this.LayoutMdi(MdiLayout.TileVertical);
    }
}
