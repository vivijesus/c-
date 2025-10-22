using System;

class Program
{
    static void Main()
    {
        // Ler as três notas
        Console.Write("Digite a primeira nota: ");
        double nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        // Calcular a média
        double media = (nota1 + nota2 + nota3) / 3;

        // Verificar se o aluno passou
        bool passou = media >= 6.0;

        // Mostrar os resultados
        Console.WriteLine($"A média do aluno é {media:F1}");
        Console.WriteLine($"O aluno passou? {passou}");
    }
}