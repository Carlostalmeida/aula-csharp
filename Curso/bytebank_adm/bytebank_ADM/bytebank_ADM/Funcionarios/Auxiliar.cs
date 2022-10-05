using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Auxiliar:Funcionario
    {
       
        public override double getBonificacao()
        {
            return Salario * 0.20;
        }
        public Auxiliar(string cpf): base(cpf, 2000)
        {
            Console.WriteLine("Criando um Auxiliar!");    
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

    }
}
