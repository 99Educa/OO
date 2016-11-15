namespace OO.Class.Heranca
{
    public class ContaCorrente : Conta
    {
        public decimal ValorLimite { get; private set; }

        public void DefinirLimite(decimal valor)
        {
            ValorLimite = valor;
        }

        public override decimal ObterSaldo()
        {
            return base.ObterSaldo() + ValorLimite;
        }
    }
}
