using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Carcteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Curso de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.Write(vazia);

        string cursos = @"Cursos Disponiveis: 
-GO 
-C# 
-Python 
-Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}
