using System;
using System.Globalization;

namespace Entrada_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("A frase escolhida foi: " + frase);
            Console.WriteLine("\n");

            string x = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("A palavra escolhida foi: " + x);
            Console.WriteLine("\n");

            string y = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("A palavra escolhida foi: " + y);
            Console.WriteLine("\n");

            string z = Console.ReadLine();
            Console.WriteLine("\n");

            Console.WriteLine("A palavra escolhida foi: " + z);
            Console.WriteLine("\n");

            string s = Console.ReadLine();
            string[] vet = s.Split(' ');
        }
    }
}
