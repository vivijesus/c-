using System;

class Program
{
    static void Main()
    {
        // Ler valor da compra
        Console.Write("Digite o valor da compra: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        // Ler valor do cupom de desconto
        Console.Write("Digite o valor do cupom de desconto: ");
        double desconto = Convert.ToDouble(Console.ReadLine());

        // Calcular valor final
        double valorFinal = valorCompra - desconto;

        // Mostrar resultado
        Console.WriteLine($"Compra finalizada! O total é de R$ {valorFinal}");
    }
}
