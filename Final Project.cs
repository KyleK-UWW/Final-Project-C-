public abstract class Cards
{
    string name;
    public Cards(string Name)
    {
        Name = name;
    }
    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }
            name = value;
        }
    }
}


