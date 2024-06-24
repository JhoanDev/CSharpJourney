using System;
using System.Globalization;
using System.IO.Pipes;

namespace Code3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Pedro";
            int idade = 25;
            double saldo = 17890.8723;

            Console.WriteLine("\n------ Usando currency (Moeda do pais) ------");

            Console.WriteLine("{0} tem {1} anos e um saldo de {2:C} reais.", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e um saldo de {saldo:C} reais.");
            Console.WriteLine(nome + " tem " + idade + " anos e um saldo de " + saldo.ToString("C") + " reais.");

            Console.WriteLine("\n------ Usando 2 casas decimais ------");

            Console.WriteLine("{0} tem {1} anos e um saldo de {2:F2} reais.", nome, idade, saldo);
            Console.WriteLine($"{nome} tem {idade} anos e um saldo de {saldo:F2} reais.");
            Console.WriteLine(nome + " tem " + idade + " anos e um saldo de " + saldo.ToString("F2") + " reais.");

            Console.WriteLine("\n------ Usando ponto ao inves de virgula ------");

            Console.WriteLine("{0} tem {1} anos e um saldo de {2} reais.", nome, idade, saldo.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine($"{nome} tem {idade} anos e um saldo de {saldo.ToString(CultureInfo.InvariantCulture)} reais.");
            Console.WriteLine(nome + " tem " + idade + " anos e um saldo de " + saldo.ToString(CultureInfo.InvariantCulture) + " reais.");

        }
    }
}