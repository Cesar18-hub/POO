using System;

namespace P3_EXE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do pH da solução: ");

            // converteo para double
            if (double.TryParse(Console.ReadLine(), out double ph))
            {
                if (ph < 7)
                {
                    Console.WriteLine("A solução é ácida.");
                }
                else if (ph == 7)
                {
                    Console.WriteLine("A solução é neutra.");
                }
                else
                {
                    Console.WriteLine("A solução é alcalina.");
                }
            }
            else
            {
                Console.WriteLine("Valor de pH inválido. Por favor, insira um número.");
            }

            Console.ReadKey();
        }
    }
}
