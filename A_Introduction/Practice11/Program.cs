using System;

namespace Practice11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            Console.WriteLine(fatorial(entrada));
        }

        static int fatorial(int n)
        {
            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat *= i;
            }
            return fat;
        }
    }
}