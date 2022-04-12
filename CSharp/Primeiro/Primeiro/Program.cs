using System;

namespace Primeiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Olá, pessoa!!");

            double exemplo = 10.35784;

            Console.WriteLine(exemplo);

            Console.WriteLine("Com duas casas descimais");
            Console.WriteLine(exemplo.ToString("F2"));

            Console.WriteLine("Com quatro casas descimais");
            Console.WriteLine(exemplo.ToString("F4"));
        }
    }
}
