class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в зоопарк");
        Zoo zoo = new Zoo();
        zoo.AddAnimal(new Mammal("Лев", 5, "молоко"));
        zoo.AddAnimal(new Bird("Орел", 3, "семечко"));
        zoo.ShowAll();
    }
}