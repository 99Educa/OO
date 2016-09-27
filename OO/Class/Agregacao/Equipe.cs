using System.Collections.Generic;

namespace OO.Class.Agregacao
{
    public class Equipe
    {
        private IList<Jogador> _jogadores;

        public IList<Jogador> Jogadores { get { return _jogadores; } }

        public Equipe()
        {
            _jogadores = new List<Jogador>();
        }

        /// <summary>
        /// Associação todo-parte de agregação.
        /// Um jogador não é criado pela equipe, 
        /// ele apenas faz parte dela.
        /// </summary>
        /// <param name="jogador"></param>
        public void AdicionarJogador(Jogador jogador)
        {
            _jogadores.Add(jogador);
        }

        /// <summary>
        /// Quando uma Equipe é destruída apenas,
        /// limpamos a lista de jogadores.
        /// </summary>
        ~Equipe()
        {
            _jogadores.Clear();
        }
    }
}
