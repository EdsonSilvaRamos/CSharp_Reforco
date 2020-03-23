using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
        }

        public override void AumentaSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 0.50;
        }
    }
}
