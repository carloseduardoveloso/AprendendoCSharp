using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 9 - Escopo");

        int idadejoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;
        string textoAdicional;

        if (acompanhado == true)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "João não está acompanhado";
        }

        if (idadejoao >= 18 || acompanhado )
        {
            Console.WriteLine(textoAdicional);  
            Console.WriteLine("Pode entrar.");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não pode entrar.");
        }

        Console.WriteLine("Tecle enter pra fechar...");
        Console.ReadLine();

    }
}