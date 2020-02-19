using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario;
        }
    }
}
