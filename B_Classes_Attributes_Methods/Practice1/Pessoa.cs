using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string MaisVelha(Pessoa pessoa)
        {
            if (this.idade > pessoa.idade) return this.nome;
            else if (this.idade < pessoa.idade) return pessoa.nome;
            return "Sao da mesma idade";
        }

    }
}
