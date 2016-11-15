using System;

namespace OO.Class.Heranca
{
    public abstract class Conta
    {
        public DateTime DataAbertura { get; protected set; }
        protected decimal Saldo { get; set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (ObterSaldo() - valor < 0)
                throw new ArgumentException("Não é possível efetuar o saque, pois o saldo ficará negativo.");

            Saldo -= valor;
        }

        public virtual decimal ObterSaldo()
        {
            return Saldo;
        }
    }
}
