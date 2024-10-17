public class Inventory
{
    public List<Item> Items=[];

    public void Display()
    {
        foreach (Item i in Items)
        {
            Console.WriteLine(i.Name);
        }
    }
}
