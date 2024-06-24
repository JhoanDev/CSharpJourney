using System;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario("Carlos Silva", 6300.00);
            Funcionario f2 = new Funcionario("Maria Oliveira", 6700.00);
            Console.WriteLine("A media salarial dos dois é: " + f1.MediaSalario(f2));
        }
    }
}