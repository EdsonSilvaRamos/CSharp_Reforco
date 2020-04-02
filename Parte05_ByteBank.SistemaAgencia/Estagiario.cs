using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parte05_ByteBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(double salario, string cpf)
            : base(salario, cpf)
        {

        }
        public override void AumentaSalario()
        {
            throw new NotImplementedException();
        }

        protected override double GetBonificacao()
        {
            throw new NotImplementedException();
        }
    }
}
