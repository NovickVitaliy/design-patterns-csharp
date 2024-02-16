namespace Patterns.Creational.Prototype.Interfaces;

public interface IPrototype<T> where T : new()
{
    T Clone();
}