using System;

class Program
{
    static void Main()
    {
        // Ler dimensões do primeiro cilindro
        Console.Write("Digite o diâmetro do primeiro cilindro: ");
        double diametro1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a altura do primeiro cilindro: ");
        double altura1 = Convert.ToDouble(Console.ReadLine());

        // Ler dimensões do segundo cilindro
        Console.Write("Digite o diâmetro do segundo cilindro: ");
        double diametro2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a altura do segundo cilindro: ");
        double altura2 = Convert.ToDouble(Console.ReadLine());

        // Calcular volumes
        double raio1 = diametro1 / 2.0;
        double raio2 = diametro2 / 2.0;
        double volume1 = Math.PI * raio1 * raio1 * altura1;
        double volume2 = Math.PI * raio2 * raio2 * altura2;

        // Verificar se é possível transferir
        bool podeTransferir = volume1 <= volume2;

        // Mostrar resultados
        Console.WriteLine($"O primeiro cilindro tem volume de {volume1}");
        Console.WriteLine($"O segundo cilindro tem volume de {volume2}");
        Console.WriteLine($"É possível transferir o primeiro para o segundo? {podeTransferir}");
    }
}
