using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_EXE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int codigo_peca1 = 0;
            int quantidade_peca1 = 0;
            double valor_peca1 = 0;
            int codigo_peca2 = 0;
            int quantidade_peca2 = 0;
            double valor_peca2 = 0;
            double valor_total = 0;  
            Console.Write("Primeira peça: ");
            Console.Write("\nCodigo: ");
            codigo_peca1 = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidade_peca1 = int.Parse(Console.ReadLine());
            Console.Write("Preço(unitario): ");
            valor_peca1 = double.Parse(Console.ReadLine());

            Console.Write("\nSegunda peça: ");
            Console.Write("\nCodigo: ");
            codigo_peca2 = int.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            quantidade_peca2 = int.Parse(Console.ReadLine());
            Console.Write("Preço(unitario): ");
            valor_peca2 = double.Parse(Console.ReadLine());

            valor_total = (valor_peca1 * quantidade_peca1)+(valor_peca2 * quantidade_peca2);
            Console.Write($"\nPreço total: {valor_total}");

            Console.ReadKey();
        }
    }
}
