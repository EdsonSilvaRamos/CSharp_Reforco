using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3500, cpf)
        {
        }

        public override void AumentaSalario()
        {
            Salario *= 1.25;
        }

        internal protected override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }
    }
}
