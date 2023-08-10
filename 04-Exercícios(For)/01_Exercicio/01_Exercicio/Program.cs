namespace _01_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Números impares de 1 a {x}:");
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}