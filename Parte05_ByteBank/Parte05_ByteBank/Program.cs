using ByteBank;
using System;

namespace Parte05_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new ContaCorrente(123, 1234);

            var conta2 = new ContaCorrente(321, 4321);

            conta2.Sacar(20);

            

            Console.WriteLine(conta.Saldo);
            Console.ReadLine();

        }
    }
}
