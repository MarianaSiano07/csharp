using System;
using System.Globalization;

namespace Processamento_Dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1
            Console.WriteLine("Exemplo 1");
            Console.WriteLine("\n");

            int x, y;
            x = 5;
            y = 2 * x;

            Console.WriteLine("Resultado da variavel x é " + x);
            Console.WriteLine("\n");
            Console.WriteLine("Resultado da variavel y é " + y);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            //Console.ReadLine();

            //Exemplo 2
            Console.WriteLine("Exemplo 2");
            Console.WriteLine("\n");
            int a;
            double b;

            a = 2;
            b = 2 * a;

            Console.WriteLine("Resultado da variavel a é " + a);
            Console.WriteLine("\n");
            Console.WriteLine("Resultado da variavel b é " + b);

            //Exemplo 3
            Console.WriteLine("Exemplo 3 -- Área de um trapézio");
            Console.WriteLine("\n");

            double baseMenor, baseMaior, altura, area;
            baseMenor = 6.0;
            baseMaior = 8.0;
            altura = 5.0;

            area = (baseMenor + baseMaior) / 2.0 * altura;
            Console.WriteLine("A área do trapézio é de " + area + " centímetros quadrados");
            Console.WriteLine("\n");

            //Exemplo 4
            Console.WriteLine("Exemplo 4");
            Console.WriteLine("\n");

            int valor, numero;
            double resultado;

            valor = 5;
            numero = 2;

            resultado = valor / numero;

            Console.WriteLine("Resultado da operação é: " + resultado);
            Console.WriteLine("\n");

            //Com Casting
            double resulModulo;

            resulModulo = (double) valor / numero;

            Console.WriteLine("Resultado da operação com Casting é: " + resulModulo.ToString("F2"));
            Console.WriteLine("\n");

            //Exemplo 5
            double teste;
            int c;

            teste = 5.0;
            c = (int) teste;

            Console.WriteLine("O valor da variável 'c' é: " + c);
            Console.WriteLine("\n");
        }
    }
}
