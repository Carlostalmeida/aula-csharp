namespace bytebank
{

    class Program
    {

        static void Main(string[] args)
        {
            
            try
            {
                ContaCorrente conta = new ContaCorrente (525, 52665);
                ContaCorrente conta2 = new ContaCorrente(5245, 52425);

                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(1000);
                //conta.Transferir(500, conta2);
                Console.WriteLine(conta.Saldo);
                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parametro: " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);

                Console.WriteLine("Informacoes da INNER EXCEPTION (excecao interna):");

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            catch (SaldoInsuficienteException)
            {
                Console.WriteLine("Excecao do tipo SaldoInsuficienteException");
            }

            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            try
            {
                Metodo();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Aconteceu um erro!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro! Nao e possivel dividir um numero por 0!");
            }
            catch
            {
                Console.WriteLine("Nao e possivel fazer essa divisao.");
            }
            
            Console.ReadLine();
        }

        private static void Metodo()
        {

            TestaDivisao(0);

        }
        private static void CarregarContas()
        {
            LeitorDeArquivo Leitor = LeitorDeArquivo("contas.txt");
            try
            {
                
                Leitor.LerProximaLinha();
                Leitor.LerProximaLinha();
                Leitor.LerProximaLinha();
                
            }
            catch(IOException ex)
            {
                Console.WriteLine("Excecao do tipo IOException capturada e tratada!");
            }
            finally
            {
                leitor.Fechar();
            }
        }
        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisao de 10 por " + divisor + " e " + resultado);

        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero /divisor;
            }
            catch
            {
                Console.WriteLine("Excecao com numero = " + numero + " e divisor = " + divisor);
                throw;
            }
            //if (divisor == -1)
            //{
            //    return -1;
            //}
            //if (divisor > numero)
            //{
            //    return -2;
            //}
            //return numero / divisor;
        }

    }
}