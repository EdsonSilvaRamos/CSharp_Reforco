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
                //Metodo();
                var conta = new ContaCorrente(123, 1234);
                var conta2 = new ContaCorrente(321, 4321);

                conta2.Transferir(10000, conta);

                //conta.Depositar(50);
                //Console.WriteLine("Saldo: " + conta.Saldo);
                //conta.Sacar(-500);
                //Console.WriteLine("Saldo: " + conta.Saldo);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine("Saldo: " + ex.Saldo);
                Console.WriteLine("Valor do saque: " + ex.ValorSaque);

                Console.WriteLine(ex.StackTrace);

                Console.WriteLine("Execeção do tipo SaldoInsuficienteException");
                Console.WriteLine(ex.Message);
            }       
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Ocorreu um erro!");
            }

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
