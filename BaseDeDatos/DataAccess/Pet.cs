namespace BaseDeDatos.DataAccess;
public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public int BreedId { get; set; }
    public Breed Breed { get; set; }
}

public class Breed
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return Name;
    }
}