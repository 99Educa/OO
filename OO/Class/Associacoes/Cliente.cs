using System;
using System.Collections.Generic;

namespace OO.Class.Associacoes
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public Cliente(string nome, string cpf, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = dataNascimento;
            this.Orcamentos = new List<Orcamento>();
        }

        public IList<Orcamento> Orcamentos { get; private set; }

        public void AdicionarOrcamento(Orcamento orcamento)
        {
            this.Orcamentos.Add(orcamento);
        }

        public void RemoverOrcamento(Orcamento orcamento)
        {
            this.Orcamentos.Remove(orcamento);
        }
    }
}
