using System;

//Leia a hora inicial e a hora final de um jogo.
//A seguir calcule a duração do jogo,
//sabendo que o mesmo pode começar em um dia e terminar em outro,
//tendo uma duração mínima de 1 hora e máxima de 24 horas.

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicial, final;
            string[] entrada = Console.ReadLine().Split(' ');
            inicial = int.Parse(entrada[0]);
            final = int.Parse(entrada[1]);
            int duracao = 24;
            if (inicial > final)
            {
                duracao = -inicial + 24;
                duracao += final;
            }
            else if (inicial < final)
            {
                duracao = final - inicial;
            }
            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}