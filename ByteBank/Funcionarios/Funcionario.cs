namespace ByteBank.Funcionarios
{
    public class Funcionario
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

        public virtual void AumentaSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {            
            return this.Salario * 0.10;
        }
    }
}
