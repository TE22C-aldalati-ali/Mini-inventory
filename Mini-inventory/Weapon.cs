
public class Weapon : Item
{
    public int MinDamage = 10;
    public int MaxDamage = 15;
    
    
    public int Attach()
    {
        return Random.Shared.Next(MinDamage, MaxDamage);
    }
}