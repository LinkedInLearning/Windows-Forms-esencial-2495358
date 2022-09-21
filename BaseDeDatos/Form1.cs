using BaseDeDatos.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

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
}
