namespace EnlaceDeDatos;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        bindingSource1.Add(new Pet()
        {
            Name = Guid.NewGuid().ToString()
        });
    }

    private void button2_Click(object sender, EventArgs e)
    {
        var form2 = new Form2(bindingSource1);
        form2.Show();
    }
}