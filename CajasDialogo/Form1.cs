namespace CajasDialogo;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (colorDialog1.ShowDialog() == DialogResult.OK)
        {
            this.BackColor = colorDialog1.Color;
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
        {
            button2.Text = folderBrowserDialog1.SelectedPath;
        }
    }

    private void button3_Click(object sender, EventArgs e)
    {
        if (fontDialog1.ShowDialog() == DialogResult.OK)
        {
            button3.Font = fontDialog1.Font;
        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            MessageBox.Show(openFileDialog1.FileName);
        }
    }

    private void button5_Click(object sender, EventArgs e)
    {
        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            MessageBox.Show(saveFileDialog1.FileName);
        }
    }
}
