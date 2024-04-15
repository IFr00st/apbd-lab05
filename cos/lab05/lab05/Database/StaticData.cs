using lab05.Models;

namespace lab05.Database;

public class StaticData
{
    public static List<Animal> Animals = new List<Animal>()
    {
        new Animal(1, "", "", 0, ""),
        new Animal(2, "", "", 0, ""),
        new Animal(3, "", "", 0, ""),
        new Animal(4, "", "", 0, ""),
    };

    public static Animal findByid(int id)
    {
        foreach (var animal in Animals)
        {
            if (animal.id == id)
            {
                return animal;
            }
        }

        return null;
    }
    
}