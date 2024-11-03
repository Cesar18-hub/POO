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
            int qtdGolos = 0, contadorQtdJogos = 0, somaGolos = 0;
            double media = 0.0;

            while (qtdGolos != -1)
            {
                Console.Write("\nQuantidade de golos ou -1 para terminar: ");
                qtdGolos = int.Parse(Console.ReadLine());

                if (qtdGolos != -1)
                {
                    somaGolos += qtdGolos;         

                    contadorQtdJogos++;
                }
            }

            media = (double)somaGolos / contadorQtdJogos;

            Console.Write("\nMedia de golos: " + Math.Round(media, 1));

            Console.ReadKey();
        }
    }
}
