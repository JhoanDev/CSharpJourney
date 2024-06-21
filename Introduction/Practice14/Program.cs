using System;

namespace Practice14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rep = int.Parse(Console.ReadLine());
            double nota = 0;
            double maiorNota = 0;
            string cod;
            string codMaiornota = " ";
            string[] entrada;
            for (int i = 0; i < rep; i++)
            {
                entrada = Console.ReadLine().Split(' ');
                cod = entrada[0];
                nota = double.Parse(entrada[1]);
                if (nota > maiorNota)
                {
                    maiorNota = nota;
                    codMaiornota = cod;
                }
            }
            if (maiorNota < 8) Console.WriteLine("Minimum note not reached");
            else Console.WriteLine(codMaiornota);

        }
    }
}