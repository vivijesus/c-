using System;

class Program
{
    static void Main()
    {
      
        const double cotacaoDolar = 5.16;

        Console.Write("Digite o valor em reais: ");
        double reais = Convert.ToDouble(Console.ReadLine());

        double dolares = reais / cotacaoDolar;

        Console.WriteLine(dolares);
    }
}
