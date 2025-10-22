using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a cor do semáforo: ");
        string cor = Console.ReadLine();

        bool podeAtravessar = cor.Equals("Verde", StringComparison.OrdinalIgnoreCase);

        Console.WriteLine($"Pode atravessar? {podeAtravessar}");
    }
}