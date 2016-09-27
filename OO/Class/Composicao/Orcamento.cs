using System;
using System.Collections.Generic;
using OO.Class.Associacao;

namespace OO.Class.Composicao
{
    public class Orcamento
    {
        private DateTime _data;
        private int _numero;
        private IList<ItemOrcamento> _itens;

        public Orcamento()
        {
            _itens = new List<ItemOrcamento>();
        }

        public Cliente Cliente
        {
            get;
            set;
        }

        public void AdicionarItem(string produto, int quantidade)
        {
            /* Validações...
             * Ex.: 
             *  Verificar se o Produto já está na lista;
             *  Verificar se a quantidade > 0...
             *  */

            _itens.Add(new ItemOrcamento(this, produto, quantidade));
        }

        /// <summary>
        /// Como a associação é todo-parte de composição,
        /// ao destruir o objeto que representa o "todo",
        /// destruimos também as "partes" que o compõe.
        /// </summary>
        ~Orcamento()
        {
            for (int i = 0; i <= _itens.Count; i++)
            {
                var item = _itens[0];
                _itens.Remove(item);
                item = null;
            }
        }
    }
}
