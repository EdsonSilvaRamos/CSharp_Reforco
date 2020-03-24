namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {        
        public static int TotalDeFunfionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected  set; }

        public Funcionario(double salario, string cpf)
        {
            this.CPF = cpf;
            this.Salario = salario;

            TotalDeFunfionarios++;
        }        

        public abstract void AumentaSalario();

        public abstract double GetBonificacao();
    }
}
