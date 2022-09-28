using bytebank.Titular;
using System.Net.NetworkInformation;

namespace bytebank 
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        private string _conta;

        public string Conta
        {    
            get
            {
                return _conta;
            }
            set
            {
                if (value == null )
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numero_agencia;

        public int Numero_Agencia 
        { 
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string nome_agencia { get; set; }
        private double saldo;
        public bool verificador;

        public bool Sacar(double valor)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if(valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        //public void SetSaldo(double valor)
        //{
        //    if(valor < 0)
        //    {
        //        return;
        //    }
        //    else
        //    {
        //        saldo = saldo + valor;
        //    }            
        //}

        //public double GetSaldo()
        //{
        //    return saldo;
        //}

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }
        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_Agencia = numero_agencia;
            Conta = conta;
        }

        //public void ExibirDadosDaConta()
        //{
        //    Console.WriteLine("Titular: " + Titular);
        //    Console.WriteLine("Conta: " + conta);
        //    Console.WriteLine("Numero Agencia: " + numero_agencia);
        //    Console.WriteLine("Nome Agencia: " + nome_agencia);
        //    Console.WriteLine("Saldo: " + saldo);
        //}

    }
}