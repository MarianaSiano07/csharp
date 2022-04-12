using System;
using System.Globalization;

namespace Primeiro
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
        }
    }
}
