using System;

namespace OO.Class.SOLID.OCP
{
    public class CalculoDescontoMelhorIdade : CalculoDescontoBase
    {
        public override double ObterPercentualDesconto()
        {
            return .1;
        }
    }
}
