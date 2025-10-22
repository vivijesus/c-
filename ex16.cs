using System;

class Program
{
    static void Main()
    {
        // Ler capacidade do tanque (litros)
        Console.Write("Digite a capacidade do tanque (em litros): ");
        int capacidadeTanque = Convert.ToInt32(Console.ReadLine());

        // Ler consumo do veículo (km por litro)
        Console.Write("Digite o consumo do veículo (km por litro): ");
        int consumo = Convert.ToInt32(Console.ReadLine());

        // Ler distância da viagem (km)
        Console.Write("Digite a distância da viagem (em km): ");
        int distancia = Convert.ToInt32(Console.ReadLine());

        // Calcular autonomia por tanque
        int autonomia = capacidadeTanque * consumo;

        // Calcular quantidade de paradas necessárias
        int paradas = distancia / autonomia;

        // Se a distância for múltiplo exato da autonomia, adicionar 1 parada extra
        if (distancia % autonomia == 0)
        {
            paradas += 1;
        }
        else
        {
            // Se não for múltiplo exato, adicionar 1 parada para a sobra
            paradas += 1;
        }

        Console.WriteLine($"Você precisará fazer {paradas} paradas para abastecer.");
    }
}
