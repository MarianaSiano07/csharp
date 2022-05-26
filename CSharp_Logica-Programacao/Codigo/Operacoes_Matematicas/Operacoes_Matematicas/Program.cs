using System;

namespace Operacoes_Matematicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            Console.WriteLine("Raiz Quadrada!");
            Console.WriteLine("\n");

            A = Math.Sqrt(x);
            Console.WriteLine("Resultade da raiz quadrada de " + x + " é de: " + A);
            Console.WriteLine("\n");

            B = Math.Sqrt(y);
            Console.WriteLine("Resultade da raiz quadrada de " + y + " é de: " + B);
            Console.WriteLine("\n");

            C = Math.Sqrt(25.0);
            Console.WriteLine("Resultade da raiz quadrada de 25.0 é de: " + C);
            Console.WriteLine("\n");

            Console.WriteLine("Potência!");
            Console.WriteLine("\n");

            double D, E, F;

            D = Math.Pow(x, y);
            Console.WriteLine("Resultade da potência de " + x + " com " + y + " é de: " + A);
            Console.WriteLine("\n");

            E = Math.Pow(y, 2.0);
            Console.WriteLine("Resultade da potência de " + y + " com 2.0 é de: " + B);
            Console.WriteLine("\n");

            F = Math.Pow(5.0, 2.0);
            Console.WriteLine("Resultade da potência de 5.0 com 2.0 é de: " + C);
            Console.WriteLine("\n");

            Console.WriteLine("Valor Absoluto ou Módulo!");
            Console.WriteLine("\n");

            double G, H;
            G = Math.Abs(x);
            Console.WriteLine("Resultade da potência de " + x + " é de: " + G);
            Console.WriteLine("\n");

            H = Math.Abs(z);
            Console.WriteLine("Resultade da potência de " + z + " é de: " + H);
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("Fórmula de Baskara");
            Console.WriteLine("\n");

            double delta;
            delta = Math.Pow(y, 2.0) - 4 * x * z;

            Console.WriteLine("Resultado do delta é: " + delta);
            Console.WriteLine("\n");

            double x1, x2;
            x1 = (-y + Math.Sqrt(delta)) / (2.0 * x);
            x2 = (y + Math.Sqrt(delta)) / (2.0 * x);

            Console.WriteLine("Resultado do x1 é: " + x1);
            Console.WriteLine("\n");

            Console.WriteLine("Resultado do x2 é: " + x2);
            Console.WriteLine("\n");
        }
    }
}
