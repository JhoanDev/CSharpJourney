using System;
using System.Globalization;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, c;
            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);
            double pi = 3.14159;

            Console.WriteLine("TRIANGULO = " + (a * c / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = " + (pi * c * c).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO = " + (((a + b) * c) / 2).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = " + (b * b).ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = " + (a * b).ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
