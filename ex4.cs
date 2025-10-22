using System;

class Program
{
    static void Main()
    {
     
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool ehPar = numero % 2 == 0;

        Console.WriteLine($"Número é par? {ehPar}");
    }
}