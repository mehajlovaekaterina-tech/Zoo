using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Zoo
{
    private List<Animal> _animals = new List<Animal>();
    public void AddAnimal(Animal animal)
    {
        _animals.Add(animal);
    }
    public void ShowAll()
    {
        foreach (var animal in _animals)
        {
            animal.MakeSound();
        }
    }
}
