using System;

//Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
//de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
//ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
//Se o ponto estiver na origem, escreva a mensagem “Origem”.
//Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
//situação.

namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saida = "Origem";
            string[] entrada = Console.ReadLine().Split(' ');

            double a = double.Parse(entrada[0]);
            double b = double.Parse(entrada[1]);

            if (a > 0 && b > 0) saida = "Q1";
            else if (a > 0 && b < 0) saida = "Q4";
            else if (b < 0 && a < 0) saida = "Q3";
            else if (b > 0 && a < 0) saida = "Q2";
            else if (a == 0 && b != 0) saida = "Eixo Y";
            else if (b == 0 && a != 0) saida = "Eixo X";
            Console.WriteLine(saida);
        }
    }
}