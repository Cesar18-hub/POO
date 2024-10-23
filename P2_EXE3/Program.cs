using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_EXE3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double X = 0;
            double Y = 0;
            double Z = 0;
            double resultado = 0;
            Console.WriteLine("\nConta: (X-Y)x(Z+2):Z");
            Console.WriteLine("\nInsira os seguintes numeros:");
            Console.Write("X:");
            X = double.Parse(Console.ReadLine());
            Console.Write("Y:");
            Y = double.Parse(Console.ReadLine());
            Console.Write("Z:");
            Z = double.Parse(Console.ReadLine());
            resultado = (X - Y) * (Z + 2) / Z;
            Console.WriteLine($"\nResultado: ({X}-{Y})x({Z}+2):{Z}={resultado}");

            Console.ReadKey();
        }
    }
}
