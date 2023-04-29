internal class program
{
    private static void Main(string[] args)
    {
        float num1, num2, subtração;

        Console.Write("Digite um numero: ");
        num1 = float.Parse(Console.ReadLine());
        Console.Write("Digite outro numero: ");
        num2 = float.Parse(Console.ReadLine());

        subtração = num1 - num2;

        Console.WriteLine($"A subtração entre os 2 numero é: {subtração}");

    }
}