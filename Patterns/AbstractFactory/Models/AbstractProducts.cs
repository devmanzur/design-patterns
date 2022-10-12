namespace Patterns.AbstractFactory.Models;

/// <summary>
/// An abstract object.
/// </summary>
public abstract class Sandwich
{
    private readonly string _name;

    public Sandwich(string name)
    {
        _name = name;
    }

    public string Name => _name;
}

/// <summary>
/// An abstract object.
/// </summary>
public abstract class Dessert
{
    private readonly string _name;

    public Dessert(string name)
    {
        _name = name;
    }

    public string Name => _name;
}