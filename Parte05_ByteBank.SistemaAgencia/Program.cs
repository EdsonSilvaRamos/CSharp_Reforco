using ByteBank;
using ByteBank.Funcionarios;
using System;

namespace Parte05_ByteBank.SistemaAgencia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dataFimPagamento = new DateTime(2020, 4, 3);
            var dataCorrente = DateTime.Now;

            var diferenca = dataFimPagamento - dataCorrente;

            var mensagem = "Vencimento em: " + GetIntervaloTempoLegivel(diferenca);

            Console.WriteLine("Data do vencimento: " + dataFimPagamento);
            Console.WriteLine("Data corrente: " + dataCorrente);
            Console.WriteLine(mensagem);


            Console.WriteLine(Environment.NewLine + "Tecle enter para sair!");
            Console.ReadLine();
        }

        public static string GetIntervaloTempoLegivel(TimeSpan diferencaDaData)
        {
            if (diferencaDaData.Days > 30)
            {
                int quantidadeMeses = diferencaDaData.Days / 30;
                if (quantidadeMeses == 1)
                {
                    return quantidadeMeses + " mês.";
                }
                return quantidadeMeses + " meses.";
            }
            else if(diferencaDaData.Days > 7 )
            {
                int quantidadeSemanas = diferencaDaData.Days / 7;
                return quantidadeSemanas + " semanas.";
            }
            else if(diferencaDaData.Days == 1)
            {
                return diferencaDaData.Days + " dia.";
            }
            else if(diferencaDaData.Days < 1)
            {
                return diferencaDaData.Hours + " hora(s)";
            }
            return diferencaDaData.Days + " dias.";
        }
    }
}
