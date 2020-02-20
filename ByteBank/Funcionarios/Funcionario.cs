namespace ByteBank.Funcionarios
{
    public class Funcionario
    {        
        public static int TotalDeFunfionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; set; }      

        public Funcionario(string cpf)
        {
            System.Console.WriteLine("Criando FUNCIONÁRIO");

            this.CPF = cpf;

            TotalDeFunfionarios++;
        }

        public virtual double GetBonificacao()
        {            
            return this.Salario * 0.10;
        }
    }
}
