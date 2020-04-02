using ByteBank;
using ByteBank.Funcionarios;
using System;

namespace Parte05_ByteBank.SistemaAgencia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var conta = new ContaCorrente(123, 1234);           

            

            Console.WriteLine(conta.Numero);

            Console.WriteLine("Tecle enter para sair!");
            Console.ReadLine();
        }
    }
}
