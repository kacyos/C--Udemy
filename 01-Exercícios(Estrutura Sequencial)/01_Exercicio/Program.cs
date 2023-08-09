namespace _01_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1,
                number2,
                soma;

            Console.Write("Digite o primeiro valor: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            number2 = int.Parse(Console.ReadLine());

            soma = number1 + number2;

            Console.WriteLine("SOMA = " + soma);
            Console.ReadKey();
        }
    }
}
