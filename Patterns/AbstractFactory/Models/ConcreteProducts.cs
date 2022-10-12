namespace Patterns.AbstractFactory.Models;

/// <summary>
/// A ConcreteProduct
/// </summary>
public class BLT : Sandwich
{
    public BLT() : base("BLT")
    {
    }
}

/// <summary>
/// A ConcreteProduct
/// </summary>
public class CremeBrulee : Dessert
{
    public CremeBrulee() : base("Creme Brulee")
    {
    }
}

/// <summary>
/// A concrete object
/// </summary>
public class GrilledCheese : Sandwich
{
    public GrilledCheese() : base("Grilled Cheese")
    {
    }
}

/// <summary>
/// A concrete object
/// </summary>
public class IceCreamSundae : Dessert
{
    public IceCreamSundae() : base("Ice Cream Sundae")
    {
    }
}