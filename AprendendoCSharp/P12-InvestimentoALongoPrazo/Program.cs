using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 12 - Investindo a Longo Prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }

            fatorRendimento += 0.001;

        }
        Console.WriteLine("Depois de 5 anos voce tera R$ " + investimento);

        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}