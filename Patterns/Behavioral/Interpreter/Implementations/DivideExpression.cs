using System.Numerics;
using Patterns.Behavioral.Interpreter.Interfaces;

namespace Patterns.Behavioral.Interpreter.Implementations;

public class DivideExpression<T> : ICalculationExpression<T> where T : INumber<T>
{
    private readonly ICalculationExpression<T> _expression1;
    private readonly ICalculationExpression<T> _expression2;

    public DivideExpression(ICalculationExpression<T> expression1, ICalculationExpression<T> expression2)
    {
        _expression1 = expression1;
        _expression2 = expression2;
    }

    public T Interpret()
    {
        return _expression1.Interpret() / _expression2.Interpret();
    }
}