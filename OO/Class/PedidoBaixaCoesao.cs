using System;

namespace OO.Class
{
    public class PedidoBaixaCoesao
    {
        public Cliente Cliente;
        public bool EhOrcamento;

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

        public void AdicionarItem(Produto produto)
        {
            // Regras para adicionar um item ao Pedido...
        }

        public void ConverterEmPedido()
        {
            // Regras para converter um orçamento em Pedido...
        }
    }

    public class Cliente
    {
        public string Nome;
        public DateTime DataNascimento;
    }

    public class Produto
    {
    }
}
