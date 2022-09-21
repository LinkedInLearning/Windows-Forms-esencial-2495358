using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesPersonalizados;
public partial class NumerosAPalabras : UserControl
{
    public NumerosAPalabras()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(textBox1.Text))
        {
            return;
        }
        if (int.TryParse(textBox1.Text, out int numero))
        {
            var resultado = Humanizer.NumberToWordsExtension.ToWords(numero, CultureInfo.CurrentCulture);
            label1.Text = resultado;
        }
    }
}
