namespace ControlesTerceros;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void coloruiControl1_ColorSelected(object sender, EventArgs e)
    {
        this.BackColor = coloruiControl1.SelectedColor;
    }
}
