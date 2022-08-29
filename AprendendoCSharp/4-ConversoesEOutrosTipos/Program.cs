using System;
    class Programa
{
    static void Main(string[] args)
    {
        
        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);
        
        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);
       
        // O long é um tipo de varial de 64 bits
        long x;
        x = 2000000000000000;
        Console.WriteLine(x);
        
        short y;
        y = 15000;
        Console.WriteLine(y);
       
        float altura;
        altura = 1.62f;
        Console.WriteLine(altura);

        // ou conforme abaixo para qualquer variavel:
                
        float altura2 = 1.62f;
        Console.WriteLine(altura2);

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();

    }
}
