using Patterns.AbstractFactory.Models;

namespace Patterns.AbstractFactory.Factories;

/// <summary>
/// A ConcreteFactory which creates concrete objects by implementing the abstract factory's methods.
/// </summary>
public class AdultCuisineFactory : RecipeFactory
{
    public override Sandwich CreateSandwich()
    {
        return new BLT();
    }

    public override Dessert CreateDessert()
    {
        return new CremeBrulee();
    }
}

/// <summary>
/// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
/// </summary>
public class KidCuisineFactory : RecipeFactory
{
    public override Sandwich CreateSandwich()
    {
        return new GrilledCheese();
    }

    public override Dessert CreateDessert()
    {
        return new IceCreamSundae();
    }
}