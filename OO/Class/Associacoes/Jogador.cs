namespace OO.Class.Associacoes
{
    public class Jogador
    {
        private Equipe _equipe;

        public string Nome { get; private set; }
        public int NumeroCamisa { get; private set; }

        public Jogador(string nome, int numeroCamisa)
        {
            Nome = nome;
            NumeroCamisa = numeroCamisa;
        }

        public void AtribuirEquipe(Equipe equipe)
        {
            _equipe = equipe;
        }

        public void RemoverEquipe()
        {
            _equipe = null;
        }

        public override string ToString()
        {
            return string.Format("{0} - camisa: {1}", Nome, NumeroCamisa);
        }
    }
}
