namespace ManejoEventos;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_MouseEnter(object sender, EventArgs e)
    {
        label1.Text = "MouseEnter";
    }

    private void Form1_MouseLeave(object sender, EventArgs e)
    {
        label1.Text = "MouseLeave";
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        label1.Text = $"{e.Location.X},{e.Location.Y}";
    }
}
