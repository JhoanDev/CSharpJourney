using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Funcionario
    {
        private string nome;
        private double salario;

        public Funcionario(string nome, double salario)
        {
            this.nome = nome;   
            this.salario = salario;
        }

        public double MediaSalario(Funcionario funcionario)
        {
            return (this.salario + funcionario.salario) / 2.0;
        }
    }
}
