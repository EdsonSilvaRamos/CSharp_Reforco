using ByteBank;
using System;

namespace Parte04_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var conta = new ContaCorrente(123, 12345);
            //Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            try
            {
                Metodo();
            }
            catch (NullReferenceException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
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
            try
            {
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não pode ocorrer uma divisão por 0");
            }
            
        }

        private static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);

            return numero / divisor;
        }
    }
}
