using System;

public interface ICommand
{
    void Execute(double value1, double value2);
}

public class AddCommand : ICommand
{
    private Calculator _calculator;

    public AddCommand(Calculator calculator)
    {
        _calculator = calculator;
    }

    public void Execute(double value1, double value2)
    {
        double result = _calculator.Add(value1, value2);
        Console.WriteLine("Resultado da soma: " + result);
    }
}

public class SubtractCommand : ICommand
{
    private Calculator _calculator;

    public SubtractCommand(Calculator calculator)
    {
        _calculator = calculator;
    }

    public void Execute(double value1, double value2)
    {
        double result = _calculator.Subtract(value1, value2);
        Console.WriteLine("Resultado da subtração: " + result);
    }
}

public class MultiplyCommand : ICommand
{
    private Calculator _calculator;

    public MultiplyCommand(Calculator calculator)
    {
        _calculator = calculator;
    }

    public void Execute(double value1, double value2)
    {
        double result = _calculator.Multiply(value1, value2);
        Console.WriteLine("Resultado da multiplicação: " + result);
    }
}

public class DivideCommand : ICommand
{
    private Calculator _calculator;

    public DivideCommand(Calculator calculator)
    {
        _calculator = calculator;
    }

    public void Execute(double value1, double value2)
    {
        double result = _calculator.Divide(value1, value2);
        Console.WriteLine("Resultado da divisão: " + result);
    }
}
