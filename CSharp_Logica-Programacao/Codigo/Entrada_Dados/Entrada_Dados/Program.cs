using System;

namespace Entrada_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parte 1");
            Console.WriteLine("\n");

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

            /*string s = Console.ReadLine();
            Console.WriteLine("\n"); */
           string[] vet = Console.ReadLine().Split(' ');

            for(int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine("Vetor " + i + ": " + vet[i]);
                Console.WriteLine("\n");
            }

            string a, b, c;
            a = vet[0];
            b = vet[1];
            c = vet[2];

            Console.WriteLine("Separando as palavras em variáveis!!");
            Console.WriteLine("\n");

            Console.WriteLine("A palavra escolhida foi: " + a);
            Console.WriteLine("\n");

            Console.WriteLine("A palavra escolhida foi: " + b);
            Console.WriteLine("\n");

            Console.WriteLine("A palavra escolhida foi: " + c);
            Console.WriteLine("\n");

            Console.WriteLine("Parte 2");
            Console.WriteLine("\n");

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("O número escolhido foi: " + n1);
            Console.WriteLine("\n");

            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("A letra escolhido foi: " + ch);
            Console.WriteLine("\n");
        }
    }
}
