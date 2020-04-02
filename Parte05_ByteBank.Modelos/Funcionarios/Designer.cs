using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {

        }

        public override void AumentaSalario()
        {
            Salario *= 1.11;
        }

        internal protected override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }
    }
}
