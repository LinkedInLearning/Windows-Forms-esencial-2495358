namespace CajasDialogoPersonalizadas;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var breedDialog = new BreedDialog();
        if (breedDialog.ShowDialog() == DialogResult.OK)
        {
            button1.Text = breedDialog.Breed;
        }
    }
}
