public class Animals
{
    private int _size;
    private string _description;
    
    public string Description
    {
        get => _description;
        set => _description = Validator.Shortener(value, 1, 20, '#');
    }
    public int Size
    {
        get => _size;
        set => _size = Validator.Limiter(value, 1, 10000);
    }

    public virtual string Info => $"{Description} <{Size}>";
    public override string ToString()
    {
        return $"ANIMALS: {Info}";
    }
}