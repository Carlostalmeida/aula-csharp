using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 11 - Calculando Poupanca 2");

        double investimento = 1000;
       
        for (int mes = 1; mes <= 12; mes++)
        {

            investimento = investimento + investimento * 0.005;

            Console.WriteLine("No mes " + mes + " voce tem R$ " + investimento);

          
        }

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}