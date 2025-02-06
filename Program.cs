using System;
using System.Collections.Generic;

// Parent class
class Fox
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}, Color: {Color}";
    }
}

// Child class
class ArcticFox : Fox
{
    public bool HasWinterCoat { get; set; } 
    public string FavoriteFood { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Has Winter Coat: {HasWinterCoat}, Favorite Food: {FavoriteFood}";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("How many foxes are in that den? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var foxList = new List<ArcticFox>();

        for (int i = 0; i < numberOfRecords; i++)
        {
            Console.WriteLine($"\n--- Fox #{i + 1} ---"); // Adds a line break and number

            var fox = new ArcticFox();

            Console.Write($"What's the Fox's Name (Fox #{i + 1})?: ");
            fox.Name = Console.ReadLine();

            Console.Write("Their Age?: ");
            fox.Age = int.Parse(Console.ReadLine());

            Console.Write("Does the fox have a winter coat? (yes/no): ");
            fox.HasWinterCoat = Console.ReadLine().ToLower() == "yes";

            Console.Write("Enter their favorite food: ");
            fox.FavoriteFood = Console.ReadLine();

            foxList.Add(fox);
        }

        // Print out the list of foxes
        Console.WriteLine("\nFoxes living in that den:");
        foreach (var fox in foxList)
        {
            Console.WriteLine("\n" + fox);
        }
    }
}