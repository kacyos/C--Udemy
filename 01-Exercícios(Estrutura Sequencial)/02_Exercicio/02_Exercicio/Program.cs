using System.Globalization;

namespace _02_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;

            Console.Write("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * (raio * raio);

            Console.WriteLine(
                $"A área do círculo é: {area.ToString("F4", CultureInfo.InvariantCulture)}"
            );
        }
    }
}
