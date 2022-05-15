using System;

class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 2 - Criando variáveis");
        int idade;
        
        idade = 27;
        Console.WriteLine("minha idade é:" + idade);

        idade = 27  - 8 + 10;
        Console.WriteLine("minha idade é:" + idade);

        idade = 27 - 5 * 10;
        Console.WriteLine("minha idade é:" + idade);

        idade = (27 + 3) / 5 ;
        Console.WriteLine("minha idade é:" + idade);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
           
    }
}

