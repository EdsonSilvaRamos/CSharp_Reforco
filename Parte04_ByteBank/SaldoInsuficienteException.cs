using System;
using System.Runtime.Serialization;

namespace ByteBank
{
    [Serializable]
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque no valor de: " + valorSaque + ". Saldo da conta: " + saldo)
        {
            this.Saldo = saldo;
            this.ValorSaque = valorSaque;
        }
    }
}