using System;
using System.Runtime.Serialization;

namespace ByteBank
{
    [Serializable]
    internal class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }
       
    }
}