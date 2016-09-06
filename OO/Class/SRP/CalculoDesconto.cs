using System;

namespace OO.Class.SRP
{
    public class CalculoDesconto : ICalculoDesconto
    {
        public double CalcularValorDesconto(PedidoAltaCoesao pedido)
        {
            var idade = DateTime.Now.Date.Subtract(pedido.Cliente.DataNascimento.Date).TotalDays / 365;
            if (idade < 18)
            {
                // Regras para Clientes com menos de 18 anos
                return pedido.ValorTotal * .01;
            }
            else if (idade >= 18 && idade <= 65)
            {
                // Regras para Adultos
                return pedido.ValorTotal * .05;
            }
            
            // Regras para Clientes acima de 65 anos
            return pedido.ValorTotal * .1;
        }
    }
}
