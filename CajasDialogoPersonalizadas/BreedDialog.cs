namespace CajasDialogoPersonalizadas;
public partial class BreedDialog : Form
{
    public string Breed { get; private set; }
    public BreedDialog()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
    }

    private void listBox1_SelectedValueChanged(object sender, EventArgs e)
    {
        if (listBox1.SelectedItem != null)
        {
            Breed = listBox1.SelectedItem.ToString();
        }
    }
}
