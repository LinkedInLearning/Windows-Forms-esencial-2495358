using BaseDeDatos.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Text.Json;

namespace BaseDeDatos;

public partial class Form1 : Form
{
    PetsDbContext db;
    public Form1()
    {
        InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        db = new PetsDbContext();
        db.Database.EnsureCreated();
        db.Pets.Load();
        db.Breeds.Load();
        petBindingSource.DataSource = db.Pets.Local.ToBindingList();
    }

    protected override void OnClosing(CancelEventArgs e)
    {
        base.OnClosing(e);

        db.Dispose();
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        var newPet = new Pet()
        {
            Name = Guid.NewGuid().ToString(),
            BreedId = 1,
            Age = 1
        };
        db.Pets.Add(newPet);
        db.SaveChanges();
        dataGridView1.Refresh();
    }

    private void toolStripButton2_Click(object sender, EventArgs e)
    {
        var pets = db.Pets.ToList();
        var json = JsonSerializer.Serialize<List<Pet>>(pets);

        var saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Archivos JSON|*.json";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            using var streamWriter = File.CreateText(saveFileDialog.FileName);
            streamWriter.WriteLine(json);
            streamWriter.Close();
        }
    }
}
