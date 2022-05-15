using System;
class Programa
{
    static void Main(String[] args)
    {
        Console.WriteLine("Projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);
        
        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(6 * 10 + 20);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cusos de Tecnologia:";
        Console.WriteLine(primeiraFrase);
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";

        char letraVazia = ' ';

        String cursos = @"Cursos Disponíveis: 
- GO
- JAVA
- Python
- C#";

        
        Console.WriteLine("Tecle enter pra fechar...");
        Console.ReadLine();

    }
}