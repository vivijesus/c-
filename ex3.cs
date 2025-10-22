using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a largura do primeiro retângulo: ");
        double largura1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a altura do primeiro retângulo: ");
        double altura1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a largura do segundo retângulo: ");
        double largura2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a altura do segundo retângulo: ");
        double altura2 = Convert.ToDouble(Console.ReadLine());

        double area1 = largura1 * altura1;
        double area2 = largura2 * altura2;

        bool iguais = area1 == area2;

        Console.WriteLine($"O primeiro retângulo possui área {area1}");
        Console.WriteLine($"O segundo retângulo possui área {area2}");
        Console.WriteLine($"Eles são iguais? {iguais}");
    }
}