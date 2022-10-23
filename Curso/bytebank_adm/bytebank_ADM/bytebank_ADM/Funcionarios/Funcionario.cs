using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - Designer
        // 3 - N..

        //private int _tipo;
        private string nome;
        private string cpf;
        private double salario;

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public abstract double getBonificacao();
      
        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            //Console.WriteLine("Criando um Funcionario.");
            totalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
       
    }
}
