namespace lab05.Models;

public class Animal
{
    public Animal(int id, string name, string category, double weight, string color)
    {
        this.id = id;
        this.name = name;
        this.category = category;
        this.weight = weight;
        this.color = color;
    }

    public int id { get; set; }
    public String name { get; set; }
    public String category { get; set; }
    public double weight { get; set; }
    public String color { get; set; }
}