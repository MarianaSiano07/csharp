using System;
using System.Globalization;

namespace Exercicio_Cinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicios Parte 2!!");
            Console.WriteLine("\n");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\n");
            
            Console.WriteLine("Exercicio URI 1013!!");
            Console.WriteLine("\n");

            int a, b, c, maiorDois, maior;

            string[] valores;
            valores = Console.ReadLine().Split(' ');

            a = int.Parse(valores[0]);
            b = int.Parse(valores[1]);
            c = int.Parse(valores[2]);

            maiorDois = (a + b + Math.Abs(a - b)) / 2;

            maior = (maiorDois + c + Math.Abs(maiorDois - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
            
            Console.WriteLine("Exercicio URI 1015!!");
            Console.WriteLine("\n");

            double x1, y1;
            double x2, y2;

            //Leitura dos pontos 1 e 2
            string[] p1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(p1[0]);
            y1 = double.Parse(p1[1]);

            string[] p2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(p2[0]);
            y2 = double.Parse(p2[1]);

            //Diferenca entre os eixos x e y dos pontos
            double diferencaX, diferencaY;
            diferencaX = x2 - x1;
            diferencaY= y2 - y1;

            //Eleva ao quadrado essa diferenca
            double potenciaX = Math.Pow(diferencaX, 2);
            double potenciaY = Math.Pow(diferencaY, 2);

            //Faz a soma das diferenças
            double soma = potenciaX + potenciaY;

            //Calcula a distancia fazendo a raiz quadrada da soma anteriormente feita
            double distancia;
            distancia = Math.Sqrt(soma);

            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
            
            Console.WriteLine("Exercicio URI 1019!!");
            Console.WriteLine("\n");

            int N;
            N = int.Parse(Console.ReadLine());

            int horas, resto;
            horas = N / 3600;
            resto = N % 3600;

            int minutos, segundos;
            minutos = N / 60;
            segundos = N % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
