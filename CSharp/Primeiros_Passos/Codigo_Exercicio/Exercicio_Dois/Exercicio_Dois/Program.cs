using System;
using System.Globalization;

namespace Exercicio_Dois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio Parte 1!!");
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("\n");
            
            Console.WriteLine("Exercicio 1010 do URI");
            Console.WriteLine("\n");

            //Declara as variáveis
            int codProd1, codProd2, qteProd1, qteProd2;
            double precoProd1, precoProd2, totalPreco;

            //Declara uma string de valores
            string[] valores = Console.ReadLine().Split(' '); //Faz o split da string
            codProd1 = int.Parse(valores[0]); //Converte string para inteiro
            qteProd1 = int.Parse(valores[1]); //Converte string para inteiro
            precoProd1 = double.Parse(valores[2], CultureInfo.InvariantCulture); //Converte string para double

            valores = Console.ReadLine().Split(' '); //Faz o split da string
            codProd2 = int.Parse(valores[0]); //Converte string para inteiro
            qteProd2 = int.Parse(valores[1]); //Converte string para inteiro
            precoProd2 = double.Parse(valores[2], CultureInfo.InvariantCulture); //Converte string para double

            //total da compra (qnt do produto 1 com preço do mesmo e qnt do produto 2 com preço do mesmo)
            totalPreco = ((precoProd1 * qteProd1) + (precoProd2 * qteProd2));

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPreco.ToString("F2", CultureInfo.InvariantCulture));
            
            //-----------------------------------------

            Console.WriteLine("Exercicio 1014 do URI");
            Console.WriteLine("\n");

            int x; //Distância total percorrida (em km)
            double y; //Total de combustível gasto (em L)

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            double consumoMedio; //Cosumo de litros por km

            consumoMedio = x / y;

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

            //-----------------------------------------
            
            Console.WriteLine("Exercicio 1016 do URI");
            Console.WriteLine("\n");

            int distancia, tempo; //Declara duas variiaveis inteiras

            distancia = int.Parse(Console.ReadLine()); //lê a distância

            tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");

            //-----------------------------------------
            
            Console.WriteLine("Exercicio 1017 do URI");
            Console.WriteLine("\n");

            int tempoGasto; //em horas
            int velocidadeMedia; //em km/h
            int distanciaPercorrida; //distancia total percorrida pelo carro

            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());

            distanciaPercorrida = tempoGasto * velocidadeMedia;

            double qntLitros = distanciaPercorrida / 12.0;

            Console.WriteLine(qntLitros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
