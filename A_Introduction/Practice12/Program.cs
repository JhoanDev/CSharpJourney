using System;

namespace Practice12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            divisores(entrada);
        }

        static void divisores(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0) Console.WriteLine(i);
            }
        }
    }
}
