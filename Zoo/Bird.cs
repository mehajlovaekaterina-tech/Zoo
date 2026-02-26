public class Bird : Animal
{
    public Bird(string name, int age, string favfood) : base(name, age, favfood) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} чирикает, его любимая еда это {Favfood}");
    }
}