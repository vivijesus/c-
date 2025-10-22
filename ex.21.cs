using System;

class Program
{
    static void Main()
    {
        // Ler salário base
        Console.Write("Digite o salário base: ");
        double salarioBase = Convert.ToDouble(Console.ReadLine());

        // Ler bônus em porcentagem
        Console.Write("Digite o bônus em %: ");
        double bonusPercentual = Convert.ToDouble(Console.ReadLine());

        // Ler descontos em reais
        Console.Write("Digite o total de descontos: ");
        double descontos = Convert.ToDouble(Console.ReadLine());

        // Calcular salário líquido
        double salarioLiquido = salarioBase + (salarioBase * bonusPercentual / 100) - descontos;

        /
        Console.WriteLine($"Seu salário líquido é de R$ {salarioLiquido}");
    }
}
