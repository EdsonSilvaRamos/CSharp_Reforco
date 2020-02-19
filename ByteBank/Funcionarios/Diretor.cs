using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class Diretor : Funcionario
    {
        public double GetBonificacao()
        {
            return this.Salario;
        }
    }
}
