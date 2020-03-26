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
                var conta = new ContaCorrente(0, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ocorreu uma exceção! Argumento: " + ex.ParamName);
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
