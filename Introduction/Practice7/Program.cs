using System;

namespace MyApp
{
    internal class Program
    {
        const int senha = 2002;
        static void Main(string[] args)
        {
            int entrada = int.Parse(Console.ReadLine());
            while (entrada != 2002)
            {
                Console.WriteLine("Senha Invalida");
                entrada = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido");
        }
    }
}