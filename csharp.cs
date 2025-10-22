namespace csharp.cs;

class VerificaFebre
{
    static void Main()
    {
        Console.Write("Digite sua temperatura em graus Celsius: ");
        string input = Console.ReadLine();
        double temperatura;

        if (double.TryParse(input, out temperatura))
        {
            bool febre = temperatura >= 37.3;
            Console.WriteLine("Você está com febre? " + febre);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }
}