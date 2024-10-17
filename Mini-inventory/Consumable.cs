public class Consumable : Item
{
    public int UsesMax = 3;
    public int UsesCurrent = 3;
    
    public void Use(Character target) 

    {
        if (UsesCurrent > 0)
        {
            target.HP = 10;
            UsesCurrent = -1;
        }
    }
}
