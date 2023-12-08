namespace ConsoleApp2;

public abstract class Animal
{
    public string Name { get; }
    public string? Species { get; }
    public string? Brood { get; }
    public string? Voice { get; }

    protected Animal(string name, string? species = null, string? brood = null, string? voice = null)
    {
        Name = name;
        Species = species;
        Brood = brood;
        Voice = voice;
    }
}