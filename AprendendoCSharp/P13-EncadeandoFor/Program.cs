using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o Projeto 13 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****



        for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
        {
            for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
            {
                Console.Write("*");
                if (contadorColunas >= contadorLinhas)
                    break;
            }
            Console.WriteLine();
            

        }
     
        Console.WriteLine("Tecle Enter para fechar...");
        Console.ReadLine();
    }
}