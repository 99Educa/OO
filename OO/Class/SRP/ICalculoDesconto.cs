using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OO.Class.SRP
{
    public interface ICalculoDesconto
    {
        double CalcularValorDesconto(PedidoAltaCoesao pedido);
    }
}
