using System;

namespace OO.Class.Heranca
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(DateTime dataAbertura, decimal saldo)
            : base(dataAbertura, saldo)
        {
        }
    }
}
