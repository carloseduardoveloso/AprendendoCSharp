using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 12 - Investindo a longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;
        
        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
                Console.WriteLine("No mês " + mes + " do ano " + anos + " você tem R$" + investimento);
            }

            fatorRendimento += 0.001;
            
        }
        Console.WriteLine("No total vc tem: R$" + investimento);

        Console.WriteLine("Tecle enter pra fechar...");
        Console.ReadLine();

    }
}