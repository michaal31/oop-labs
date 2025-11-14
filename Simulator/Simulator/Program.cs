// See https://aka.ms/new-console-template for more information
Console.WriteLine("Starting Simulator!\n");

static void TestCreatures()
{
    Creature c = new() { Name = "   Shrek    ", Level = 20 };
    c.SayHi();
    Console.WriteLine(c.Info);

    c = new("  ", -5);
    c.SayHi();
    Console.WriteLine(c.Info);

    c = new("  donkey ") { Level = 7 };
    c.SayHi();
    Console.WriteLine(c.Info);

    c = new("Puss in Boots – a clever and brave cat.");
    c.SayHi();
    Console.WriteLine(c.Info);

    c = new("a                            troll name", 5);
    c.SayHi();
    Console.WriteLine(c.Info);

    var a = new Animals() { Description = "   Cats " };
    Console.WriteLine(a.Info);

    a = new() { Description = "Mice           are great", Size = 40 };
    Console.WriteLine(a.Info);
}
