namespace lab05.Models;

public class Visit
{
    public String date { get; set; }
    public Animal animal { get; set; }
    public String brief { get; set; }
    public int cost { get; set; }

    public Visit(string date, Animal animal, string brief, int cost)
    {
        this.date = date;
        this.animal = animal;
        this.brief = brief;
        this.cost = cost;
    }
}