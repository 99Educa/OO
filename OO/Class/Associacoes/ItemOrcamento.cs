namespace OO.Class.Associacoes
{
    public class ItemOrcamento
    {
        private Orcamento _orcamento;
        private Produto _produto;
        private int _quantidade;
        private decimal _preco;

        public Produto Produto { get { return _produto; } }
        public int Quantidade { get { return _quantidade; } }
        public decimal Preco { get { return _preco; } }

        internal ItemOrcamento(Orcamento orcamento, Produto produto, int quantidade)
        {
            _orcamento = orcamento;
            _produto = produto;
            _preco = produto.Preco;
            _quantidade = quantidade;
        }
    }
}
