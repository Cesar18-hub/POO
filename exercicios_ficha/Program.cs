using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_ficha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region EXE1
            /*
            int valor1 = 0;
            int valor2 = 0;
            int valor3 = 0;
            int valor4 = 0;
            int max = 0;

            Console.Write("digite o 1 valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.Write("digite o 2 valor: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.Write("digite o 3 valor: ");
            valor3 = int.Parse(Console.ReadLine());

            Console.Write("digite o 4 valor: ");
            valor4 = int.Parse(Console.ReadLine());

            max = valor1;

            if (valor2 > max)
            {
                max = valor2; 
            }
            if (valor3 > max)
            {
                max = valor3; 
            }
            if (valor4 > max)
            {
                max = valor4;  
            }

            Console.Write($"\nO maior valor é {max}");

            Console.ReadKey();
            */
            #endregion

            #region EXE2
            /*
            int mes = 0;

            Console.Write("Digite o numero do mes: ");
            mes = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 9)
            {
                Console.Write("31 dias");
            }
            else if (mes == 4 || mes == 6 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.Write("30 dias");
            }
            else if (mes == 2)
            {
                Console.Write("28 ou 29 dias");
            }
            else
            {
                Console.Write("Numero invalido.");
            }

            Console.ReadKey();
            */
            #endregion

            #region EXE3
            /*
            int[] PH = new int[5];
            string[] solucao = new string[5];

            for (int i = 0; i < PH.Length; i++)
            {
                Console.Write($"Insira o {i + 1} valor PH: ");
                PH[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < solucao.Length; i++)
            { 
                if (PH[i] < 7)
                {
                    solucao[i] = "acido";
                }
                else if (PH[i] > 7)
                {
                    solucao[i] = "alcalino";
                }
                else 
                { 
                    solucao[i] = "neutro";
                }
            }
            Console.WriteLine($"O PH1 é {solucao[0]}");
            Console.WriteLine($"O PH2 é {solucao[1]}");
            Console.WriteLine($"O PH3 é {solucao[2]}");
            Console.WriteLine($"O PH4 é {solucao[3]}");
            Console.WriteLine($"O PH5 é {solucao[4]}");

            Console.ReadKey();
            */
            #endregion
        }
    }
}
