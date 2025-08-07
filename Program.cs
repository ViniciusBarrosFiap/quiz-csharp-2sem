using System;

class Program
{
    static void Main(string[] args)
    {
        // This is a simple C# program that prints "Hello, World!" to the console.
        Console.WriteLine("Seja bem vindo ao Quiz feito em C#");

        string resposta1 = "";
        string resposta2 = "";
        string resposta3 = "";

        string pergunta1 = "Qual dia da semana descobriram o Brasil? \nA) sexta-feira \nB) quinta-feira \nC) Domingo \nD) quarta-feira";
        Console.WriteLine(pergunta1);
        resposta1 = Console.ReadLine().ToUpper();
        if (resposta1 == "A")
        {
            Console.WriteLine("Resposta correta!");
        }
        else
        {
            Console.WriteLine("Resposta incorreta. A resposta correta é A) sexta-feira.");
        }
        Console.WriteLine();

        string pergunta2 = "Qual é o maior planeta do sistema solar? \nA) Terra \nB) Sol \nC) Júpiter \nD) Saturno";
        if (resposta2 == "C")
        {
            Console.WriteLine("Resposta correta!");
        }
        else
        {
            Console.WriteLine("Resposta incorreta. A resposta correta é C) Júpiter.");
        }
        Console.WriteLine();

        string pergunta3 = "Qual é a classe do ornitorrinco\nA) Mamifero \nB) Réptil \nC) Peixe \nD) Anfíbio";
        if (resposta3 == "A")
        {
            Console.WriteLine("Resposta correta!");
        }
        else
        {
            Console.WriteLine("Resposta incorreta. A resposta correta é A) Mamifero.");
        }
        Console.WriteLine();




    }
}