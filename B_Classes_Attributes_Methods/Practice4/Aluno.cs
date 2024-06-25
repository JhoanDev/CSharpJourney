using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    internal class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;
        private double nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            this.nome = nome;
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
        }

        public double NotaFinal()
        {
            return this.nota1 + this.nota2 + this.nota3;
        }

        public bool Aprovado()
        {
            double nota = this.NotaFinal();
            if (nota >= 60.0) return true;
            return false;
        }
    }
}