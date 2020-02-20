using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciadorBonificacao();

            var carlos = new Funcionario("123.456.789-50");
            
            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            Console.WriteLine(Funcionario.TotalDeFunfionarios);

            gerenciador.Registrar(carlos);

            var roberta = new Diretor("987.654.321-80");
            
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            Console.WriteLine(Funcionario.TotalDeFunfionarios);
            
            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificacao através da referência Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificacao através da referência Funcionário: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);


            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
