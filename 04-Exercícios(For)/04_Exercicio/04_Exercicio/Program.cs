using System.Globalization;

namespace _04_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Informe um número para x e y: ");
                string[] line = Console.ReadLine().Split(' ');
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double div = (double)x / y;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}