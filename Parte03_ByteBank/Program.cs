using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            var sistemaInterno = new SistemaInterno();

            var roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            var camila = new GerenteDeContas("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            var parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiro, "123456");

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

            var edson = new Desenvolvedor("347.846.828-05");
            edson.Nome = "Edson";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(edson);
                        
            Console.WriteLine("Total de bonificações do mês: " + gerenciadorBonificacao.GetTotalBonificacao());
        }
    }
}
