using ByteBank;
using ByteBank.Funcionarios;
using Humanizer;
using System;

namespace Parte05_ByteBank.SistemaAgencia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dataFimPagamento = new DateTime(2020, 6, 20);
            var dataCorrente = DateTime.Now;

            var diferenca = dataFimPagamento - dataCorrente;

            var mensagem = "Vencimento em: " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine("Data do vencimento: " + dataFimPagamento);
            Console.WriteLine("Data corrente: " + dataCorrente);
            Console.WriteLine(mensagem);


            Console.WriteLine(Environment.NewLine + "Tecle enter para sair!");
            Console.ReadLine();
        }       
    }
}
