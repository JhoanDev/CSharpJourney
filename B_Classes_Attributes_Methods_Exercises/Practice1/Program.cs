using System;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Maria", 26);
            Pessoa p2 = new Pessoa("Joao", 22);
            Console.WriteLine("A pessoa com maior idade é: " + p1.MaisVelha(p2));
        }
    }
}