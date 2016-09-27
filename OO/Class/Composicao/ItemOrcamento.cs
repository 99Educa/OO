namespace OO.Class.Composicao
{
    internal class ItemOrcamento
    {
        private Orcamento _orcamento;
        private string _produto;
        private int _quantidade;

        internal ItemOrcamento(Orcamento orcamento, string produto, int quantidade)
        {
            _orcamento = orcamento;
            _produto = produto;
            _quantidade = quantidade;
        }
    }
}
