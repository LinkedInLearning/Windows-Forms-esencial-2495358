namespace SistemaDeArchivos;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            using var streamWriter = File.CreateText(saveFileDialog1.FileName);
            streamWriter.WriteLine(textBox1.Text);
            streamWriter.Close();
        }
    }
}
