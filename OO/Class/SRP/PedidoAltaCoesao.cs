namespace OO.Class.SRP
{
    /// <summary>
    /// A classe de Pedido agora está com alta coesão, pois possui apenas 1 motivo para mudar:
    /// - Se alterar regras de negócio do Pedido.
    /// 
    /// Algumas vantagens que temos ao remover a responsabilidade do cálculo de descontos do Pedido:
    /// - A classe Pedido fica coesa;
    /// - As estratégias de desconto podem mudar à vontade, sem causar impacto no Pedido (Open-closed principle);
    /// - Como dependemos de uma interface, reduzimos o acoplamento;
    /// - Consequentemente, aumentamos a testabilidade do Pedido;
    /// - Melhora na legibilidade do código.
    /// </summary>
    public class PedidoAltaCoesao
    {
        private ICalculoDesconto _calculoDesconto;
        private double _valorDesconto;
        private double _valorTotal;

        public Cliente Cliente;
        public bool EhOrcamento;
        public double ValorTotal { get { return _valorTotal; } }

        public PedidoAltaCoesao(ICalculoDesconto calculoDesconto)
        {
            _calculoDesconto = calculoDesconto;
        }

        public void CalcularDesconto()
        {
            _valorDesconto = _calculoDesconto.CalcularValorDesconto(this);
        }

        public void AdicionarItem(Produto produto, int quantidade)
        {
            // Regras para adicionar um item ao Pedido...
        }

        public void ConverterOrcamentoEmPedido()
        {
            // Regras para converter um orçamento em Pedido...
        }
    }
}
