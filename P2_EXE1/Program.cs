//-----------------------------------------------------------------
//    <copyright file="Aula_4.cs"    company="IPCA">
//     Copyright (c) IPCA-EST 2024. All rights reserved.
//    </copyright>
//    <date>2024-10-22</date>
//    <time>14:01</time>
//    <version>0.1</version>
//    <author>tcastro</author>
//    <description></description>
//-----------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace P2_EXE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";
            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';
            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;
            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo o preço é € " + preco1);
            Console.WriteLine(produto2 + ", cujo o preço é € " + preco2);
            Console.WriteLine("\nRegistro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero);
            Console.WriteLine("\nMedida com oito casas decimais: " + media);
            Console.WriteLine("Arredondamento (três casas decimais): " + Math.Round(media, 3));
            Console.WriteLine("Separador decimal invariant culture: " + Math.Round(media, 3).ToString(CultureInfo.InvariantCulture));

            Console.ReadKey();

            //(NOTA: text spel, biblioteca)
            //(sempre para ler dados sem ser texto tem de se meter int.parce(Console.Readline());)
        }
    }
}
