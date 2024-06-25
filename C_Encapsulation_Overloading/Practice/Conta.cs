using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Conta
    {
        private string _nome;
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string nome, int numero)
        {
            _nome = nome;
            Numero = numero;
            Saldo = 0.0;
        }
        public Conta(string nome, int numero, double saldo)
        {
            _nome = nome;
            Numero = numero;
            Saldo = saldo;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public void Deposito(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else
            {
                Console.WriteLine("Não foi possivel realizar o deposito.");
            }
        }

        public void Saque(double valor)
        {
            if (valor > 0)
            {

                Saldo -= valor + 5; //Taxa de 5
            }
            else
            {
                Console.WriteLine("Não foi possivel realizar o saque.");
            }
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: "
                + _nome + ", Saldo: $ " + Saldo.ToString("F2");
        }
    }
}