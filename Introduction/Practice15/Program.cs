using System;

namespace Practice15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada = Console.ReadLine();
            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                Console.Write(entrada[i]);
            }
            Console.WriteLine();
        }
    }
}
