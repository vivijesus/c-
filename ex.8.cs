using System;

class Program
{
    static void Main()
    {

        Console.Write("Digite o nome do livro: ");
        string nomeLivro = Console.ReadLine();

    
        Console.Write("Digite o total de páginas: ");
        int totalPaginas = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o tempo de leitura por página (em segundos): ");
        int tempoPorPagina = Convert.ToInt32(Console.ReadLine());

        double tempoTotalHoras = (totalPaginas * tempoPorPagina) / 3600.0;

        Console.WriteLine($"Você lerá {nomeLivro} em {tempoTotalHoras} horas.");
    }
}
``
