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
public class Monster : Cards  //IAttack()?
{
    int strength;
    double hp;
    public Monster(string Name,int Strength,double HP) : base(Name)
    {
        Strength = strength;
    }
    public int Strength
    {
        get=> strength;
        set
        {
            if(value <= 0 ||  value >= 100)
            {
                throw new ArgumentOutOfRangeException(nameof(strength));
            }
            strength = value;
        }
    }
    public double HP
    {
        get => hp;
        set
        {
            if(value >= 0 || value >= 999.99)
            {
                throw new ArgumentOutOfRangeException(nameof(hp));
            }
            hp = value;
        }
    }
}

