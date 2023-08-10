namespace _05_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial de: ");
            int n = int.Parse(Console.ReadLine());

            int fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat = fat * i;
            }

            Console.WriteLine(fat);
        }
    }
}