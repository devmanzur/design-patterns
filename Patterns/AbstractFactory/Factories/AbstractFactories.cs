using Patterns.AbstractFactory.Models;

namespace Patterns.AbstractFactory.Factories;

/// <summary>
/// The AbstractFactory class, which defines methods for creating abstract objects.
/// </summary>
public abstract class RecipeFactory
{
    public abstract Sandwich CreateSandwich();
    public abstract Dessert CreateDessert();
}