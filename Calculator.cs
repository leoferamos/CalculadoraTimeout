using System;

public class Calculator
{
    // Método para realizar a operação de soma
    public double Add(double value1, double value2)
    {
        return value1 + value2;
    }

    // Método para realizar a operação de subtração
    public double Subtract(double value1, double value2)
    {
        return value1 - value2;
    }

    // Método para realizar a operação de multiplicação
    public double Multiply(double value1, double value2)
    {
        return value1 * value2;
    }

    // Método para realizar a operação de divisão
    public double Divide(double value1, double value2)
    {
        if (value2 != 0)
        {
            return value1 / value2;
        }
        else
        {
            Console.WriteLine("Erro: Divisão por zero!");
            return double.NaN; // Retorna NaN (Not a Number) em caso de divisão por zero
        }
    }
}
