using ByteBank;
using System;

namespace Parte04_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var conta1 = new ContaCorrente(123, 1234);
                var conta2 = new ContaCorrente(321, 4321);

                //conta1.Transferir(10000, conta2);
                conta2.Sacar(10000);
            }
            catch (OperacaoFincanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                //Console.WriteLine(Environment.NewLine);
                //Console.WriteLine(ex.InnerException.Message);
                //Console.WriteLine(ex.InnerException.StackTrace);
                //Console.WriteLine(Environment.NewLine);

            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Digite a tecla Enter para sair!");
            Console.ReadLine();
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro na divisão do número: " + numero +" e do divisor: " + divisor);
                throw;
            }
        }
    }
}
