// See https://aka.ms/new-console-template for more information

using Patterns.AbstractFactory.Factories;

try
{
    Console.WriteLine("Who are you? (A)dult or (C)hild?");
    var input = Console.ReadKey().KeyChar;
    RecipeFactory factory = input switch
    {
        'A' => new AdultCuisineFactory(),
        'C' => new KidCuisineFactory(),
        _=> throw new InvalidDataException()
    };
    
    var sandwich = factory.CreateSandwich();
    var dessert = factory.CreateDessert();
    
    Console.WriteLine("\nSandwich: " + sandwich.Name);
    Console.WriteLine("\nDessert: " + dessert.Name);
}
catch (Exception e)
{
    Console.WriteLine("Invalid input, Error: {0}",e.Message);
}