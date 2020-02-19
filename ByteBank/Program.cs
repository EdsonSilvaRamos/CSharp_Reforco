using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciadorBonificacao();

            var carlos = new Funcionario();
            
            carlos.Nome = "Carlos";
            carlos.CPF = "123.456.789-50";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            var roberta = new Diretor();
            
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;
            
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
