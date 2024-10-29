using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_EXE2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string nome1 = "";
            string nome2 = "";
            int salario1 = 0;
            int salario2 = 0;
            int media = 0;
            Console.Write("Primeira pessoa: ");
            Console.Write("\nNome completo: ");
            nome1 = Console.ReadLine();
            Console.Write("Salario: ");
            salario1 = int.Parse(Console.ReadLine());
            Console.Write("\nSegunda pessoa: ");
            Console.Write("\nNome completo: ");
            nome2 = Console.ReadLine();
            Console.Write("Salario: ");
            salario2 = int.Parse(Console.ReadLine());
            media = (salario1 + salario2)/2;
            Console.WriteLine($"\nA media dos salarios é {media}");

            Console.ReadKey();
        }
    }
}
