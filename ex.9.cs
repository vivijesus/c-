using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a capacidade do tanque (em litros): ");
        double capacidade = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a quantidade atual de combustível (em litros): ");
        double quantidadeAtual = Convert.ToDouble(Console.ReadLine());

        bool precisaAbastecer = quantidadeAtual <= (capacidade / 4);

        Console.WriteLine($"Carro precisa ser reabastecido? {precisaAbastecer}");
    }
}
