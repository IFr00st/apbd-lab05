﻿using lab05.Models;

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

    public static List<Visit> Visits = new List<Visit>()
    {
        new Visit("2000", findByid(1), "", 0),
        new Visit("2001", findByid(1), "", 0),
        new Visit("2002", findByid(2), "", 0)
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
    
    public static void removeByid(int id)
    {
        foreach (var animal in Animals)
        {
            if (animal.id == id)
            {
                StaticData.Animals.Remove(animal);
            }
        }
        
    }

    public static List<Visit> getVisitsById(int id)
    {
        List<Visit> tmp = new List<Visit>();
        foreach (var visit  in Visits)
        {
            if (visit.animal.id == id)
            {
                tmp.Add(visit);
            }
        }

        return tmp;
    }

    public static void addNewVisit(String date, Animal animal, String brief, double cost)
    {
        Visits.Add(new Visit(date,animal,brief,cost));
    }
    
}