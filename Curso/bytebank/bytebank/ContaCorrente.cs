using bytebank.Titular;
using System.Net.NetworkInformation;

namespace bytebank 
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
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

        public void DefinirSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            saldo = valor;
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Conta: " + conta);
            Console.WriteLine("Numero Agencia: " + numero_agencia);
            Console.WriteLine("Nome Agencia: " + nome_agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

    }
}