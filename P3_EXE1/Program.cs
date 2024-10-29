using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_EXE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string nome1 = "";
            string nome2 = "";
            int idade1 = 0;
            int idade2 = 0;
            Console.Write("Primeira pessoa: ");
            Console.Write("\nNome completo: ");
            nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            idade1 = int.Parse(Console.ReadLine());
            Console.Write("\nSegunda pessoa: ");
            Console.Write("\nNome completo: ");
            nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            idade2 = int.Parse(Console.ReadLine());
            if (idade1 > idade2)
            {
                Console.WriteLine($"\n{nome1} é mais velho/a.");
            }
            else
            {
                Console.WriteLine($"\n{nome2} é mais velho/a.");
            }

            Console.ReadKey();
        }
    }
}
