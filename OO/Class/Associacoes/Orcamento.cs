using System;
using System.Collections.Generic;

namespace OO.Class.Associacoes
{
    public class Orcamento : IDisposable
    {
        public Guid Numero { get; private set; }
        public DateTime Data { get; private set; }

        public bool EhPedido { get; private set; }
        public DateTime? DataConversaoEmPedido { get; private set; }

        public void ConverterEmPedido()
        {
            if (EhPedido)
                throw new Exception("Este orçamento já foi convertido.");

            DataConversaoEmPedido = DateTime.Now;
            this.EhPedido = true;
        }

        // Agregação (1)
        public Cliente Cliente { get; private set; }

        public void TrocarCliente(Cliente novoCliente)
        {
            if (EhPedido)
                throw new Exception("Não é possível trocar o Cliente. Este orçamento já foi convertido em Pedido.");

            Cliente = novoCliente;
        }

        // Composição (1..N)
        public IList<ItemOrcamento> Itens { get; private set; }

        public Orcamento(Cliente cliente)
        {
            this.Numero = Guid.NewGuid();
            this.Itens = new List<ItemOrcamento>();
            this.Data = DateTime.Now;
            this.Cliente = cliente;
            this.Cliente.AdicionarOrcamento(this);
        }

        public void AdicionarItem(Produto produto, int quantidade)
        {
            /* Validações...
             * Ex.: 
             *  Verificar se o Produto já está na lista;
             *  Verificar se a quantidade > 0...
             *  */

            Itens.Add(new ItemOrcamento(this, produto, quantidade));
        }

        public decimal ValorTotal { get; private set; }

        public decimal CalcularValorTotal()
        {
            ValorTotal = 0;

            foreach (var item in Itens)
            {
                ValorTotal += item.Preco;
            }

            return ValorTotal;
        }

        /// <summary>
        /// Como a associação é todo-parte de composição,
        /// ao destruir o objeto que representa o "todo",
        /// destruimos também as "partes" que o compõe.
        /// </summary>
        public void Dispose()
        {
            for (int i = 0; i <= Itens.Count; i++)
            {
                var item = Itens[0];
                Itens.Remove(item);
                item = null;
            }

            Cliente.RemoverOrcamento(this);
        }
    }
}
