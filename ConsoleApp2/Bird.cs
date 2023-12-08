namespace ConsoleApp2;

public class Bird : Animal, IFlying
{
    public string? Fly { get; }
    
    public Bird(string name, string species, string voice, string? brood = null, string? fly = null) : base(name, species, brood, voice)
    {
        Fly = fly;
    }
}