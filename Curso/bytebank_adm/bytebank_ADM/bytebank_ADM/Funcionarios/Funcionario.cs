using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - Designer
        // 3 - N..

        //private int _tipo;
        private string nome;
        private string cpf;
        private double salario;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public double Salario { get => salario; set => salario = value; }

        public double getBonificacao()
        {
          
            return Salario * 0.1;

        }
    }
}
