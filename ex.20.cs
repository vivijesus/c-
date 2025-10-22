using System;

class Program
{
    static void Main()
    {
        // Preços dos tamanhos
        double precoPequeno = 13.50;
        double precoMedio = 15.00;
        double precoGrande = 17.50;

        // Ler quantidade de açaís de cada tamanho
        Console.Write("Quantidade de açaís pequenos: ");
        int quantidadePequeno = Convert.ToInt32(Console.ReadLine());

        Console.Write("Quantidade de açaís médios: ");
        int quantidadeMedio = Convert.ToInt32(Console.ReadLine());

        Console.Write("Quantidade de açaís grandes: ");
        int quantidadeGrande = Convert.ToInt32(Console.ReadLine());

        // Ler valor do cupom de desconto em porcentagem
        Console.Write("Digite o desconto em %: ");
        double descontoPercentual = Convert.ToDouble(Console.ReadLine());

        // Calcular total sem desconto
        double total = (quantidadePequeno * precoPequeno) +
                       (quantidadeMedio * precoMedio) +
                       (quantidadeGrande * precoGrande);

        // Aplicar desconto
        total = total * (1 - descontoPercentual / 100);

        // Mostrar resultado
        Console.WriteLine($"Total à pagar é R$ {total}");
    }
}
