using System;

namespace OO.Class.SRP
{
    /// <summary>
    /// Esta classe Pedido possui baixa coesão, pois possui mais de 1 motivo para mudar:
    /// - Se alterar alguma estratégia para cálculo de desconto;
    /// - Se alterar alguma regra de negócio do Pedido;
    /// </summary>
    public class PedidoBaixaCoesao
    {
        public Cliente Cliente { get; private set; }
        public bool EhOrcamento { get; }

        public void CalcularDesconto()
        {
            var idade = DateTime.Now.Date.Subtract(Cliente.DataNascimento.Date).TotalDays / 365;
            if (idade < 18)
            {
                // Regras para Clientes com menos de 18 anos
            }
            else if (idade >= 18 && idade <= 65)
            {
                // Regras para Adultos
            }
            else
            {
                // Regras para Clientes acima de 65 anos
            }
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
