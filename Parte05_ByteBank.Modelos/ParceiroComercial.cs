using ByteBank.Sistemas;
using Parte05_ByteBank.Modelos;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel

    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper(); 
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.CompararSenhas(Senha, senha);
        }
    }
}
