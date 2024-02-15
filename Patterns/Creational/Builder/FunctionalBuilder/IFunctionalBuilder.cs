namespace Patterns.Creational.Builder.FunctionalBuilder;

public interface IFunctionalBuilder<T> where T : new()
{
    IFunctionalBuilder<T> Configure(Action<T> action);
    T Build();
    IFunctionalBuilder<T> Reset();
}