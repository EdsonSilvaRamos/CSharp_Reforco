using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            var usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao Sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
                return false;
            }

        }        
    }
}
