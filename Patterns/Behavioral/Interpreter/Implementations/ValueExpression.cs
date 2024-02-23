using System.Numerics;
using Patterns.Behavioral.Interpreter.Interfaces;

namespace Patterns.Behavioral.Interpreter.Implementations;

public class ValueExpression<T> : ICalculationExpression<T> where T : INumber<T>
{
    private readonly T _value;

    public ValueExpression(T value)
    {
        _value = value;
    }

    public T Interpret()
    {
        return _value;
    }
}