using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnlaceDeDatos;
public partial class Form2 : Form
{
    public Form2(BindingSource bindingSource)
    {
        InitializeComponent();
        listBox1.DataSource = bindingSource;
        listBox1.DisplayMember = "Name";
    }
}
