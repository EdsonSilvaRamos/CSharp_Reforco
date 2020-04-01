using ByteBank;
using System;

namespace Parte05_ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new ContaCorrente(123, 1234);

            Console.WriteLine(conta.Numero);

            Console.WriteLine("Digite enter para sair!");
            Console.ReadLine();
        }
    }
}
