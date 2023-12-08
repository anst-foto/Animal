namespace ConsoleApp2;

public class SwimmingBird : Bird, ISwimming
{
    public string? Swim { get; }
    
    
    public SwimmingBird(string name, string species, string voice, string? brood = null, string? fly = null, string? swim = null) : base(name, species, voice, brood, fly)
    {
        Swim = swim;
    }
}