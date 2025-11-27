using Simulator;

public abstract class Creature
{
    private string _name;
    private int _level;

    public string Name
    {
        get => _name;
        set => _name = Validator.Shortener(value, 1, 20, '#');
    }

    public int Level
    {
        get => _level;
        set => _level = Validator.Limiter(value, 1, 100);
    }

    public abstract int Power { get; }
    public abstract string Info { get; }
    public abstract void SayHi();
    
    protected Creature(string name = "Unknown", int level = 1)
    {
        Name = name;
        Level = level;
    }
    public override string ToString()
        => $"{GetType().Name.ToUpper()}: {Info}";
    
}


  