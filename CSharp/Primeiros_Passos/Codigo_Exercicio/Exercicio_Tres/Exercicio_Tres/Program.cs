using System;
using System.Globalization;

namespace Exercicio_Tres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios Parte 1!!");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            /*
            Console.WriteLine("Atividade 1005 do URI");
            Console.WriteLine("\n");

            double a, b;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            double media = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));

            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            
            Console.WriteLine("Atividade 1006 do URI");
            Console.WriteLine("\n");

            double a, b, c;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double media;

            media = ((a * 2) + (b * 3) + (c * 5)) / (2 + 3 + 5);

            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\n");
            */
            Console.WriteLine("Atividade 1009 do URI");
            Console.WriteLine("\n");

            string nome;
            double salario, montanteTotal;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            montanteTotal = double.Parse(Console.ReadLine());

            double salarioFinal;

            salarioFinal = montanteTotal * 15.0 / 100 + salario;

            Console.WriteLine("TOTAL = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
