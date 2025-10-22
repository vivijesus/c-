using System;

class Program
{
    static void Main()
    {
      
        const double precoAcai = 13.50;

        Console.Write("Digite a quantidade de açaís: ");
        int quantidade = Convert.ToInt32(Console.ReadLine());

        double total = quantidade * precoAcai;

        Console.WriteLine($"Total à pagar é R$ {total}");
    }
}
