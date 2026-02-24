public class Animal
{
    private string _name;
    private int _age;
    public string Name => _name;
    public int Age => _age;
    public Animal(string name, int age)
    {
        _name = name;
        _age = age;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Животное издает звук");
    }
}