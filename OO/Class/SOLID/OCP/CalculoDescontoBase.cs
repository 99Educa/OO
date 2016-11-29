namespace OO.Class.SOLID.OCP
{
    public abstract class CalculoDescontoBase : ICalculoDesconto
    {
        public double CalcularValorDesconto(PedidoAltaCoesao pedido)
        {
            return pedido.ValorTotal * ObterPercentualDesconto();
        }

        public abstract double ObterPercentualDesconto();
    }
}
