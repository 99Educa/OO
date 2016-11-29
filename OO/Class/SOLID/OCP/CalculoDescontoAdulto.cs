namespace OO.Class.SOLID.OCP
{
    public class CalculoDescontoAdulto : CalculoDescontoBase
    {
        public override double ObterPercentualDesconto()
        {
            return .05;
        }
    }
}
