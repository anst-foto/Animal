namespace ConsoleApp2;

public class Dog : Animal
{
    private const string SPECIES = "dog";
    private const string VOICE = "woof";

    public Dog(string name, string? brood = null) : base(name, SPECIES, brood, VOICE)
    { }
}