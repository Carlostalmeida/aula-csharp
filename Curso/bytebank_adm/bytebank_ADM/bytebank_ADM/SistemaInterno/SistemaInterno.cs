using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar (senha);
            if (usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao Sistema ByteBank!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuario ou senha incorreto.");
                return false;
            }
        }

        //public bool Logar(Diretor funcionario, string senha)
        //{
        //    bool usuarioAutenticado = funcionario.Autenticar (senha);
        //    if (usuarioAutenticado == true)
        //    {
        //        Console.WriteLine("Bem vindo ao Sistema ByteBank!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Usuario ou senha incorreto.");
        //        return false;
        //    }
        //}
    }
}
