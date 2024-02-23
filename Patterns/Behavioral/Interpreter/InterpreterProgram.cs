using Patterns.Behavioral.Interpreter.Implementations;
using Patterns.Behavioral.Interpreter.Interfaces;

namespace Patterns.Behavioral.Interpreter;

public class InterpreterProgram
{
    public static void InterpreterMain(string[] args)
    {
        // ((5 + 3) * 8) / 3

        ICalculationExpression<double> three = new ValueExpression<double>(3);
        ICalculationExpression<double> five = new ValueExpression<double>(5);
        ICalculationExpression<double> eight = new ValueExpression<double>(8);

        ICalculationExpression<double> addition = new AdditionExpression<double>(three, five);
        ICalculationExpression<double> multiplication = new MultiplyExpression<double>(addition, eight);
        ICalculationExpression<double> division = new DivideExpression<double>(multiplication, three);

        Console.WriteLine(division.Interpret());
    }
}