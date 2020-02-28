using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();

            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            var gerenciadorBonificacao = new GerenciadorBonificacao();

            var pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            var roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            var igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            var camila = new GerenteDeContas("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
