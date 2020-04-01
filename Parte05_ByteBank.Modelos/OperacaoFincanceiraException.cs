using System;

namespace Parte04_ByteBank
{
    public class OperacaoFincanceiraException : Exception
    {
        public OperacaoFincanceiraException()
        {
        }

        public OperacaoFincanceiraException(string mensagem)
            : base(mensagem)
        {
        }

        public OperacaoFincanceiraException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {
        }

    }
}
