using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_EXE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string nome = "";
            int numero_de_quartos = 0;
            int idade = 0;
            double preco = 0;
            Console.Write("Nome completo: ");
            nome = Console.ReadLine();
            Console.Write("\nQuantidade de quartos na sua casa: ");
            numero_de_quartos = int.Parse(Console.ReadLine());
            Console.Write("\nIdade: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("\nPreço de um produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("\n" + nome);
            Console.WriteLine(numero_de_quartos);
            Console.WriteLine(idade);
            Console.WriteLine(preco);

            Console.ReadKey();
        }
    }
}
