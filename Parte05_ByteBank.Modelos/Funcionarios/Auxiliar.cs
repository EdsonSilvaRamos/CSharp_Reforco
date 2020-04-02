using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(2000, cpf)
        {

        }

        public override void AumentaSalario()
        {
            Salario *= 1.10;
        }

        internal protected override double GetBonificacao()
        {
            return this.Salario * 0.20;
        }
    }
}
