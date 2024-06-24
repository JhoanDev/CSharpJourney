using System;
using System.Globalization;

namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cotacao, qntdolar;
            Console.Write("Qual a cotacao do dolar: ");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a quantidade que deseja comprar: ");
            qntdolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais: " + ConversorDeMoeda.ConverteParaReais(cotacao,qntdolar).ToString("C"));
        }
    }
}