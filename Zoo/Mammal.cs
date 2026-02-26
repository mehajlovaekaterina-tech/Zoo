using System.Xml.Linq;
public class Mammal : Animal
{
    public Mammal(string name, int age, string favfood) : base(name, age, favfood) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} рычит, его любимая еда это {Favfood}");
    }
}