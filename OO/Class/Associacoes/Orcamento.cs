using System;
using System.Collections.Generic;

namespace OO.Class.Associacoes
{
    public class Orcamento : IDisposable
    {
        public Orcamento(Cliente cliente)
        {
            this.Itens = new List<ItemOrcamento>();
            this.Data = DateTime.Now;
            this.Cliente = cliente;
            this.Cliente.AdicionarOrcamento(this);
        }

        // Associação simples
        public Cliente Cliente { get; private set; }

        public DateTime Data { get; private set; }
        public int Numero { get; private set; }

        // Composição
        public IList<ItemOrcamento> Itens { get; private set; }

        public void AdicionarItem(string produto, int quantidade)
        {
            /* Validações...
             * Ex.: 
             *  Verificar se o Produto já está na lista;
             *  Verificar se a quantidade > 0...
             *  */

            Itens.Add(new ItemOrcamento(this, produto, quantidade));
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
