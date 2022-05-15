using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e outros tipos");

        double salario;
        salario = 3000.15;
        Console.WriteLine(salario);

        int salarioInteiro;
        salarioInteiro = (int)salario;
        Console.WriteLine(salarioInteiro);

        long x;
        x = 100000000000000000;
        Console.WriteLine(x);

        short y;
        y = 19000;
        Console.WriteLine(y);

        float altura = 1.62f;
        Console.WriteLine(altura);


        Console.WriteLine("Tecle enter pra fechar...");
        Console.ReadLine();

    }
}