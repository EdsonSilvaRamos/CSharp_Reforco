using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentaSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
