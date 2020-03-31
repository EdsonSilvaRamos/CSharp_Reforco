using ByteBank;
using System;
using System.IO;

namespace Parte04_ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarregarContas();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Digite a tecla Enter para sair!");
            Console.ReadLine();
        }

        public static void CarregarContas()
        {
            LeitorDeArquivo leitor = null;

            try
            {
                leitor = new LeitorDeArquivo("contas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                
            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            }
            finally
            {
                if (leitor != null)
                {
                    leitor.Fechar();
                }                
            }            

        }

        public static void TestaExcecoes()
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
        }

        public static void Metodo()
        {
            TestaDivisao(0);
        }

        public static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);

        }

        public static int Dividir(int numero, int divisor)
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
