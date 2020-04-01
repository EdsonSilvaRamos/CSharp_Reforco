using Parte04_ByteBank;
using System;

namespace ByteBank
{
    [Serializable]
    public class SaldoInsuficienteException : OperacaoFincanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string mensagem) 
            : base(mensagem)
        {
        }

        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Tentativa de saque no valor de: " + valorSaque + ". Saldo da conta: " + saldo)
        {
            this.Saldo = saldo;
            this.ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            :base(mensagem, excecaoInterna)
        {
        }
    }
}