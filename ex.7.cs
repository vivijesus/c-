using System;

class Program
{
    static void Main()
    {
        // Ler altura e peso
        Console.Write("Digite sua altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite seu peso (em kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        // Calcular IMC
        double imc = peso / (altura * altura);

        // Verificar se está acima do peso ideal
        bool acimaPesoIdeal = imc > 24.9;

        // Mostrar resultados
        Console.WriteLine($"Seu IMC é {imc}");
        Console.WriteLine($"Está acima do peso ideal? {acimaPesoIdeal}")
    }
}