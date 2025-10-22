using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Qual é o personagem de Friends que trabalha com TI?");
        string resposta = Console.ReadLine();

        bool correta = resposta.Equals("Chandler", StringComparison.OrdinalIgnoreCase);

        Console.WriteLine($"Resposta correta: {correta}");
    }
}