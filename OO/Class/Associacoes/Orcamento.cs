using System;
using System.Collections.Generic;

namespace OO.Class.Associacoes
{
    public class Orcamento : IDisposable
    {
        public Guid Numero { get; private set; }
        public DateTime Data { get; private set; }

        // Agregação (1)
        public Cliente Cliente { get; private set; }        

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

        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;

            foreach (var item in Itens)
            {
                valorTotal += item.Preco;
            }

            return valorTotal;
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
