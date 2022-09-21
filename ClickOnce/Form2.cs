using BaseDeDatos.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDatos;
public partial class Form2 : Form
{
    public Form2(List<Pet> pets, string fileName)
    {
        InitializeComponent();
        dataGridView1.DataSource = pets;
        toolStripStatusLabel1.Text = $"{fileName} ({pets.Count} registro(s) en total)";
    }
}