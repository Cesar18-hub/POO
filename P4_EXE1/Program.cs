using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_EXE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<double> alturas = new List<double>();
            string entrada;
            int n_pessoa = 1;
            double soma = 0;

            Console.WriteLine("Digite 'm' para fazer a média. ");
            // Ler as alturas até que o usuário decida parar
            while (true)
            {
                Console.Write($"Insira a altura da {n_pessoa}º: ");
                entrada = Console.ReadLine();

                // Verifica se o usuário quer fazer a média
                if (entrada == "m")
                {
                    break;
                }

                // Converte a entrada do usuário para double
                double altura = double.Parse(entrada);
                alturas.Add(altura); // Adiciona a altura à lista
                n_pessoa++;
            }

            // Calcula a média das alturas
            foreach (var altura in alturas)
            {
                soma += altura;
            }
            Console.WriteLine($"Média das {(n_pessoa - 1)} alturas: {(soma / alturas.Count)}");

            Console.ReadKey();

        }
    }
}
