using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    internal class Funcionario
    {
        private string nome;
        private double salarioBruto;
        private double imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.imposto = imposto;
        }
    
        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            salarioBruto += salarioBruto * porcentagem / 100;
        }

        public override string ToString()
        {
            return nome + ", " + SalarioLiquido().ToString("C");
        }
    }
}
