
int cislo1 = int.Parse(Console.ReadLine());
int cislo2 = int.Parse(Console.ReadLine());
Console.Clear();

if (cislo1 < cislo2)
{
    Console.WriteLine($"{cislo1},{cislo2} ");
}
else
{
    Console.WriteLine($"{cislo2},{cislo1} ");
}

