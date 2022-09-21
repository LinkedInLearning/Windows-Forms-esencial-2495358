using System.Diagnostics;

namespace CicloVidaForms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        Debug.WriteLine(nameof(Form1_Load));
    }

    private void Form1_Activated(object sender, EventArgs e)
    {
        Debug.WriteLine(nameof(Form1_Activated));
    }

    private void Form1_Shown(object sender, EventArgs e)
    {
        Debug.WriteLine(nameof(Form1_Shown));
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.DrawString("LinkedIn Learning",
            new Font("Arial", 14),
            new SolidBrush(Color.Red), 0, 0);
        Debug.WriteLine(nameof(Form1_Paint));
    }

    private void Form1_Deactivate(object sender, EventArgs e)
    {
        Debug.WriteLine(nameof(Form1_Deactivate));
    }

    private void Form1_Move(object sender, EventArgs e)
    {
        Debug.WriteLine(nameof(Form1_Move));
    }
}
