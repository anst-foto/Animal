using ConsoleApp2;

var dog = new Dog("Pet");
var bird = new Bird("chicken", "chicken", "chicken");
var penguin = new SwimmingBird("penguin", "penguin", "krya", null, null, "good");

GetVoice(dog);
GetVoice(bird);
GetVoice(penguin);

GetFly(bird);
GetFly(penguin);

GetSwim(penguin);

return;

void GetVoice(Animal animal)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(animal.Voice);
    Console.ResetColor();
}

void GetFly(IFlying fly)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(fly.Fly);
    Console.ResetColor();
}

void GetSwim(ISwimming swim)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(swim.Swim);
    Console.ResetColor();
}