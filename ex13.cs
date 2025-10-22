using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o peso em quilos: ");
        double quilos = Convert.ToDouble(Console.ReadLine());

        double gramas = quilos * 1000;

        Console.WriteLine(gramas);
    }
}
