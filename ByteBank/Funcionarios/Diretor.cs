using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        } 

        public override double GetBonificacao()
        {
            return this.Salario;
        }
    }
}
