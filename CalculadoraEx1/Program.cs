using System;

namespace CalculadoraSimples
{
    public class  Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("== Calculadora Simples ==");
            Console.WriteLine();

            // 1. Leitura do primeiro número
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            
            // 2. Leitura da operação
            Console.Write("Digite a operação (+, -, *, /): ");
            string operacao = Console.ReadLine();

            // 3. Leitura do segundo número
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            // 4. Realização da operação
            double resultado = 0;
            bool operacaoValida = true;

            switch (operacao)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        operacaoValida = false;
                    }
                    break;
                default:
                    Console.WriteLine("Erro: Operação inválida.");
                    operacaoValida = false;
                    break;
            }

            // 5. Exibição do resultado
            if (operacaoValida)
            {
                Console.WriteLine($"Resultado: {resultado}");
            }
        }
    }
}
