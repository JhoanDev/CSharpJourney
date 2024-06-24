using System;

namespace Practice13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qnt = int.Parse(Console.ReadLine());
            double a, b, c;
            string[] entrada;
            for (int i = 0; i < qnt; i++)
            {
                entrada = Console.ReadLine().Split(' ');
                a = double.Parse(entrada[0]);
                b = double.Parse(entrada[1]);
                c = double.Parse(entrada[2]);
                Console.WriteLine(MediaPonderada(a, b, c).ToString("F1"));
            }
        }
        static double MediaPonderada(double n1, double n2, double n3)
        {
            double media = (n1 * 2 + n2 * 3 + n3 * 5) / 10.0;
            return media;
        }
    }
}