namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - Funcionario
        // 1 - Diretor
        // 2 - Designer
        // 3 - Coordenador
        // 4 - Gerente de contas
        // N - ...
        private int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            this._tipo = tipo;
        }

        public double GetBonificacao()
        {
            if (_tipo == 1)
            {
                return this.Salario;
            }
            return this.Salario * 0.10;
        }
    }
}
