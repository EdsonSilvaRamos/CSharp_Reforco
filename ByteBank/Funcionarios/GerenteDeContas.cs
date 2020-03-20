using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public string Senha { get; set; }

        public GerenteDeContas(string cpf) : base(4000, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
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
