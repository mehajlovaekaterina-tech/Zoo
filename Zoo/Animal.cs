using System.Threading.Channels;

public class Animal
{
    private string _name;
    private int _age;
    private int _soundCount;

    public string Name => _name;
    public int Age => _age;

    public Animal(string name, int age)
    {
        _name = name;
        _age = age;
        _soundCount = 1; 
    }

    public int GetSoundCount()
    {
        return _soundCount;
    }

    public virtual void MakeSound()
    {
        _soundCount++; 
        Console.WriteLine("Животное издает звук");
    }
    
} 


