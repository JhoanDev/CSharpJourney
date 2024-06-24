using System;

//Leia 2 valores inteiros (A e B). Após,
//o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos",
//indicando se os valores lidos são múltiplos entre si.
//Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.


namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);
            bool saida = false;
            if (a >= b)
            {
                if (a % b == 0) saida = true;
            }
            else
            {
                if (b % a == 0) saida = true;
            }
            Console.WriteLine(saida ? "Sao Multiplos" : "Nao sao Multiplos");
        }
    }
}