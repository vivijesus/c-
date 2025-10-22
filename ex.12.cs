using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor da compra: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a porcentagem de desconto: ");
        double percentualDesconto = Convert.ToDouble(Console.ReadLine());

        double valorFinal = valorCompra * (1 - percentualDesconto / 100);

        Console.WriteLine($"Compra finalizada! O total é de R$ {valorFinal}");
    }
}
