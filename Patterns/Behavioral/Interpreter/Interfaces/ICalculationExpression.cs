using System.Numerics;

namespace Patterns.Behavioral.Interpreter.Interfaces;

public interface ICalculationExpression<T> where T : INumber<T>
{
    T Interpret();
}