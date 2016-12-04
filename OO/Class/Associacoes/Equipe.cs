using System;
using System.Collections.Generic;
using System.Text;

namespace OO.Class.Associacoes
{
    public class Equipe : IDisposable
    {
        public string Nome { get; private set; }
        public IList<Jogador> Jogadores { get; private set; }

        public Equipe(string nome)
        {
            this.Nome = nome;
            this.Jogadores = new List<Jogador>();
        }

        /// <summary>
        /// Associação todo-parte de agregação.
        /// Um jogador não é criado pela equipe, 
        /// ele apenas faz parte dela.
        /// </summary>
        /// <param name="jogador"></param>
        public void AdicionarJogador(Jogador jogador)
        {
            this.Jogadores.Add(jogador);
            jogador.AtribuirEquipe(this);
        }

        /// <summary>
        /// Quando uma Equipe é destruída apenas,
        /// limpamos a lista de jogadores.
        /// </summary>
        public void Dispose()
        {
            foreach (var jogador in Jogadores)
                jogador.RemoverEquipe();

            this.Jogadores.Clear();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("Equipe: ").AppendLine(Nome).AppendLine("Jogadores: ");

            foreach (var jogador in Jogadores)
                sb.AppendLine(jogador.ToString());

            return sb.ToString();
        }
    }
}
