using System;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Jhoan Fernandes", 6000.00, 1000.00);
            Console.WriteLine("Funcionario: " + f1);
            f1.AumentarSalario(10.0);
            Console.WriteLine("Funcionario: " + f1);
        }
    }
}