using System;

class Program
{
    static void Main()
    {
        // Preço do açaí
        const double precoAcai = 13.50;

        // Ler quantidade de açaís comprados
        Console.Write("Digite a quantidade de açaís: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        // Calcular total
        double total = quantidade * precoAcai;

        // Mostrar resultado
        Console.WriteLine($"Total à pagar é R$ {total}");
    }
}
