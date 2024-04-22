using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Calculator calculator = new Calculator();
            CalculatorClient client = new CalculatorClient(calculator);

            
            TimeoutGenerator timeoutGenerator = TimeoutGenerator.GetInstance();

            
            while (true)
            {
                // Mostra o menu da calculadora
                client.ShowMenu();

                // Gera valores de timeout aleatórios entre 1 e 10 segundos
                int timeout = timeoutGenerator.GetRandomTimeout(1000, 10000); 
                Console.WriteLine("Timeout gerado: " + timeout + " ms");

                // Espera para dar tempo de o usuário visualizar o timeout
                System.Threading.Thread.Sleep(timeout);

                // Verifica se o timeout é maior que 6000ms (6 segundos)
                if (timeout > 6000)
                {
                    Console.WriteLine("Tempo expirado. Voltando para o menu...");
                }
                else
                {
                    
                    Console.WriteLine("Digite o número da operação que deseja realizar:");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    client.ProcessChoice(choice);
                }

                // Espera para dar tempo de o usuário visualizar a mensagem
                System.Threading.Thread.Sleep(2000);

                
                Console.Clear();
            }
        }
    }
}
