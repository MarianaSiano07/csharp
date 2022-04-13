using System;
using System.Globalization;

namespace Saida_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Olá, pessoa!!");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            double exemplo = 10.35784;

            Console.WriteLine("Impressão normal");
            Console.WriteLine(exemplo);
            Console.WriteLine("\n");

            Console.WriteLine("Com duas casas decimais");
            Console.WriteLine(exemplo.ToString("F2"));
            Console.WriteLine("\n");

            Console.WriteLine("Com quatro casas decimais");
            Console.WriteLine(exemplo.ToString("F4"));
            Console.WriteLine("\n");

            Console.WriteLine("Com uma função");
            Console.WriteLine(exemplo.ToString("F2", CultureInfo.InvariantCulture));

            //Concatenação

            double troco = 15.52;
            double trocoDolares = 15.52 * 4.59;
            int operacao = 63;

            Console.WriteLine("Resultado = " + operacao);
            Console.WriteLine("\n");

            Console.WriteLine("O valor do troco eh de " + troco + " reais");
            Console.WriteLine("\n");

            Console.WriteLine("O valor do troco eh de " + trocoDolares + " dolares");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("O valor do troco eh de " + trocoDolares.ToString("F2") + " dolares");
        }
    }
}