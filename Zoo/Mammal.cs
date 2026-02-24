using System.Xml.Linq;
public class Mammal : Animal
{
    public Mammal(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} рычит");
    }
}