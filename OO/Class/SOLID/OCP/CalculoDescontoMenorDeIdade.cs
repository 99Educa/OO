namespace OO.Class.SOLID.OCP
{
    public class CalculoDescontoMenorDeIdade : CalculoDescontoBase
    {
        public override double ObterPercentualDesconto()
        {
            return .01;
        }
    }
}
