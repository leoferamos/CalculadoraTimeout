using System;

public class CalculatorClient
{
    private Calculator _calculator;

    public CalculatorClient(Calculator calculator)
    {
        _calculator = calculator;
    }

    // Mostra menu da calculadora
    public void ShowMenu()
    {
        Console.WriteLine("Escolha uma operação:");
        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtração");
        Console.WriteLine("3. Multiplicação");
        Console.WriteLine("4. Divisão");
        Console.WriteLine("5. Sair");
    }

    // Método para a escolha do usuário
    public void ProcessChoice(int choice)
    {
        double value1, value2;

        switch (choice)
        {
            case 1:
                Console.WriteLine("Digite o primeiro valor:");
                value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                value2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Resultado: " + _calculator.Add(value1, value2));
                break;
            case 2:
                Console.WriteLine("Digite o primeiro valor:");
                value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                value2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Resultado: " + _calculator.Subtract(value1, value2));
                break;
            case 3:
                Console.WriteLine("Digite o primeiro valor:");
                value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                value2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Resultado: " + _calculator.Multiply(value1, value2));
                break;
            case 4:
                Console.WriteLine("Digite o primeiro valor:");
                value1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o segundo valor:");
                value2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Resultado: " + _calculator.Divide(value1, value2));
                break;
            case 5:
                Console.WriteLine("Saindo...");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
