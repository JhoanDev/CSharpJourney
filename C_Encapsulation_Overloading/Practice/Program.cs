using System;
using System.Globalization;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int numero;
            double deposito, saque;
            char aux;
            Conta p;

            Console.Write("Insira o número da conta: ");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Insira o titular da conta: ");
            nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            aux = char.Parse(Console.ReadLine());
            if (aux == 's' || aux == 'S')
            {
                Console.Write("Insira o valor do depósito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p = new Conta(nome, numero, deposito);
            }
            else
            {
                p = new Conta(nome, numero);
            }


            Console.WriteLine("\nDados da conta: ");
            Console.WriteLine(p);

            Console.Write("\nInsira um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Deposito(deposito);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(p);

            Console.Write("\nInsira um valor para saque: ");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Saque(saque);

            Console.WriteLine("\nDados da conta atualizados: ");
            Console.WriteLine(p);
        }
    }
}