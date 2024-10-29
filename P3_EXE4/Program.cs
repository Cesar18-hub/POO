using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_EXE4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double raio = 0;
            double area = 0;

            do
            {
                Console.Write("\nRaio do círculo: ");
                raio = double.Parse(Console.ReadLine());

                if (raio <= 0)
                {
                    Console.WriteLine("\nO número não pode ser menor ou igual a 0.");
                }

            } while (raio <= 0); 
            area = 3.14159 * (raio * raio);
            Console.Write($"Área do círculo: {area:F4}");

            Console.ReadKey();
        }
    }
}
