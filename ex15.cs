using System;

class Program
{
    static void Main()
    {
        // Ler valor total da compra
        Console.Write("Digite o valor total da compra: ");
        double valorTotal = Convert.ToDouble(Console.ReadLine());

        // Ler quantidade de parcelas
        Console.Write("Digite a quantidade de parcelas: ");
        int parcelas = Convert.ToInt32(Console.ReadLine());

        // Calcular valor de cada parcela
        double valorParcela = valorTotal / parcelas;

        // Mostrar mensagem formatada
        Console.WriteLine($"Sua compra de R$ {valorTotal} em {parcelas}x de R$ {valorParcela} foi concluída");
    }
}
