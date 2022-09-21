using BaseDeDatos.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BaseDeDatos;
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        
    }

    private void abrirArchivoJSONToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Archivos JSON|*.json";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var fileName = openFileDialog.FileName;
            using var stream = File.OpenRead(fileName);
            using var streamReader = new StreamReader(stream);
            var json = streamReader.ReadToEnd();

            var pets = JsonSerializer.Deserialize<List<Pet>>(json);

            var form2 = new Form2(pets, fileName);
            form2.MdiParent = this;
            form2.WindowState = FormWindowState.Maximized;
            form2.Show();
        }
    }

    private void consultarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var form1 = new Form1();
        form1.MdiParent = this;
        form1.WindowState = FormWindowState.Maximized;
        form1.Show();
    }
}