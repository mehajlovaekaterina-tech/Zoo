public class Animal
{
    private string _name;
    private int _age;
    private string _favfood;
    public string Name => _name;

    public string Favfood => _favfood;
    public int Age => _age;
    public Animal(string name, int age, string favfood)
    {
        _name = name;
        _age = age;
        _favfood = favfood;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Животное издает звук");
    }
}