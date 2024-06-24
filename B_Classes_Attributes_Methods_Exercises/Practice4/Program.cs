using System;

namespace Practice4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Jhoan Fernandes", 27.00, 31.00, 32.00);
            Console.WriteLine("Nota final: " + a1.NotaFinal());
            Console.WriteLine(a1.Aprovado() ? "Aprovado" : "Reprovado");
            if (!a1.Aprovado())
            {
                Console.WriteLine("Faltam " + (60.00 - a1.NotaFinal()).ToString("F2") + " pontos");
            }

            Aluno a2 = new Aluno("Lucas Silva", 17.00, 20.00, 15.00);
            Console.WriteLine("Nota final: " + a2.NotaFinal());
            Console.WriteLine(a2.Aprovado() ? "Aprovado" : "Reprovado");
            if (!a2.Aprovado())
            {
                Console.WriteLine("Faltam " + (60.00 - a2.NotaFinal()).ToString("F2") + " pontos");
            }
        }
    }
}