using System.Diagnostics;
using System.IO.IsolatedStorage;

namespace AlmacenamientoAislado;

public partial class Form1 : Form
{
    private const string data = "datos.txt";
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var isf = IsolatedStorageFile.GetUserStoreForApplication();
        if (isf.FileExists(data))
        {
            using var stream = isf.OpenFile(data, FileMode.Open);
            using var streamReader = new StreamReader(stream);
            var text = streamReader.ReadToEnd();
            textBox1.Text = text;
            streamReader.Close();
            stream.Close();
        }
    }

    private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    {
        var isf = IsolatedStorageFile.GetUserStoreForApplication();
        if (isf.FileExists(data))
        {
            isf.DeleteFile(data);
        }
        using var stream = isf.CreateFile(data);
        using var streamWriter = new StreamWriter(stream);
        var text = textBox1.Text;
        streamWriter.WriteLine(text);
        streamWriter.Close();
        stream.Close();
    }
}