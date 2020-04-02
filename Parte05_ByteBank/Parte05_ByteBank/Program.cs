using ByteBank;
using System;

namespace Parte05_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new ContaCorrente(123, 1234);

            Console.WriteLine(conta.Saldo);
            Console.ReadLine();

        }
    }
}
