namespace _06_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular os divisores de: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}