Character c = new();

c.Backpack.Display();

Armor hjälm = new() {Name = "dragonhelmet"};
Console.WriteLine($"Det finns en ny {hjälm.Name}");
Console.WriteLine("Vill du plocka up den");

Console.ReadLine();

string Answer = Console.ReadLine();

if ( Answer == "ja")

{
    c.Backpack.Items.Add(hjälm);
    Console.WriteLine($"{hjälm.Name} har lagts till i din backpack.");
}

else if (Answer =="nej")
{
    Console.WriteLine($"du har missat {hjälm.Name}");
}

Console.ReadLine();