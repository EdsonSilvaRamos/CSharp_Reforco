using ByteBank;
using System;

namespace Parte04_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new ContaCorrente(123, 12345);

            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
