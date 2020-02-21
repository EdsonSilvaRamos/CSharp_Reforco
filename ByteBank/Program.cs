using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerenciador = new GerenciadorBonificacao();

            var carlos = new Funcionario(2000, "123.456.789-50");            
            carlos.Nome = "Carlos";

            Console.WriteLine(Funcionario.TotalDeFunfionarios);

            carlos.AumentaSalario();
            gerenciador.Registrar(carlos);

            Console.WriteLine("Novo salário Carlos: " + carlos.Salario);
            
            var roberta = new Diretor("987.654.321-80");            
            roberta.Nome = "Roberta";            

            Console.WriteLine("");                             
            Console.WriteLine(Funcionario.TotalDeFunfionarios);

            roberta.AumentaSalario();
            gerenciador.Registrar(roberta);

            Console.WriteLine("Novo salário Roberta: " + roberta.Salario);

            Console.WriteLine("");
            Console.WriteLine("Bonificações: ");

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("");
            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
