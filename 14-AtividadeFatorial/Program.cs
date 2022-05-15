using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 14 - Atividade Fatorial");

        int fatorial = 1;
        for(int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("O fatorial de " + i + " = " + fatorial);
        }

        Console.WriteLine("Tecle enter pra fechar...");
        Console.ReadLine();

    }
}