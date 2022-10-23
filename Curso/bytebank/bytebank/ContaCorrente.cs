using bytebank.Titular;
using System.Net.NetworkInformation;

namespace bytebank 
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        //public static double TaxaOperacao { get; set; }

        public static int TotalDeContasCriadas { get; set; }

        public int ContadorSaquesNaoPermitidos { get; set; }

        public int ContadorTransferenciaNaoPermitidas { get; set; }
       
        private int _conta;

        public int Conta
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

        private int Numero_Agencia 
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

        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                
                ContadorSaquesNaoPermitidos++;
                                
                throw new SaldoInsuficienteException("Saldo insusficiente para saque no valor de " + valor);
            }
            saldo -= valor;
          
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciaNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operacao nao realizada.", ex);
            }

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

        public ContaCorrente(int numero_agencia, int conta)
        {
            Numero_Agencia = numero_agencia;
            Conta = conta;

            //TaxaOperacao = 30 / TotalDeContasCriadas;
            if(numero_agencia <= 0)
            {
                throw new ArgumentException("Os argumentos numero e agencia devem ser maiores que 0.", nameof(numero_agencia));
            }
            if(conta <= 0)
            {
                throw new ArgumentException("Os argumentos numero e agencia devem ser maiores que 0.", nameof(conta));
            }

            TotalDeContasCriadas = +1;
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