using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 7 - Condicionais");

        int idadejoao = 16;
        int quantidadePessoas = 2;

        if (idadejoao >= 18)
        {
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            if (quantidadePessoas > 1)
            {
                Console.WriteLine("Ele está acompanhando. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

        }

        Console.WriteLine("Tecle enter pra fechar...");
        Console.ReadLine();

    }
}