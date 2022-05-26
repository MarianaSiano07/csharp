using System;
using System.Globalization;

namespace Exercicio_Um
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EXERCICIOS PARTE 1!!");
            Console.WriteLine("\n");
            Console.WriteLine("--------------------------------------------------------------");

            Console.WriteLine("Exercicio 1001 do URI");
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int x = a + b;

            Console.WriteLine("X = " + x);
            
            //--------------------------------------------------------------

            Console.WriteLine("Exercicio 1002 do URI");
            Console.WriteLine("\n");
            double n = 3.14159;
            double raio, area;
            area = 0;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * (raio * raio);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            //--------------------------------------------------------------

            Console.WriteLine("Exercicio 1003 do URI");
            Console.WriteLine("\n");

            int a, b;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int soma;

            soma = a + b;

            Console.WriteLine("SOMA = " + soma);

            //--------------------------------------------------------------

            Console.WriteLine("Exercicio 1004 do URI");
            Console.WriteLine("\n");

            int valor, numero;
            valor = int.Parse(Console.ReadLine());
            numero = int.Parse(Console.ReadLine());

            int prod;

            prod = valor * numero;

            Console.WriteLine("PROD = " + prod);
            
            //--------------------------------------------------------------

            Console.WriteLine("Exercicio 1007 do URI");
            Console.WriteLine("\n");

            int a, b, c, d;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int diferenca;
            diferenca = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);
            
            Console.WriteLine("Exercicio 1006 do URI");
            Console.WriteLine("\n");

            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double media = ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
            
            Console.WriteLine("Exercicio 1008 do URI");
            Console.WriteLine("\n");

            int numeroFunc, numeroHoras;
            double salarioHoras;

            numeroFunc = int.Parse(Console.ReadLine()); ;
            numeroHoras = int.Parse(Console.ReadLine());

            salarioHoras = double.Parse(Console.ReadLine());

            double salarioTotal;
            salarioTotal = numeroHoras * salarioHoras;

            Console.WriteLine("NUMBER = " + numeroFunc);
            Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
