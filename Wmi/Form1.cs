using System.Management;

namespace Wmi;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
        var mo = searcher.Get().Cast<ManagementObject>().First();
        label1.Text = mo.GetPropertyValue("Manufacturer").ToString();
        label2.Text = mo.GetPropertyValue("SystemFamily").ToString();
        label3.Text = mo.GetPropertyValue("Description").ToString();
        label4.Text = mo.GetPropertyValue("PrimaryOwnerName").ToString();
    }
}