class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();
        zoo.AddAnimal(new Mammal("Лев", 5, "молоко"));
        zoo.AddAnimal(new Bird("Орел", 3, "семечко"));
        zoo.ShowAll();
    }
}