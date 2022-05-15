using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 8 - Condicionais");

        int idadejoao = 16;
        int quantidadePessoas = 2;

        if (idadejoao >= 18 || quantidadePessoas > 1)
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            Console.WriteLine("Não pode entrar.");
        }

        Console.WriteLine("Tecle enter pra fechar...");
        Console.ReadLine();

    }
}