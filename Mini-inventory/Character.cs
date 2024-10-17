
public class Character
{

    public int HP;
    public string Name;
    public Inventory Backpack;

    public Character()
    {
        Backpack = new();
        Backpack.Items.Add(new Weapon() {Name = "Axe"});
        Backpack.Items.Add(new Consumable() {Name = "Potion"});
    }
}
