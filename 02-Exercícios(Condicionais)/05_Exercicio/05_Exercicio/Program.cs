using System.Globalization;

namespace _05_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o código e a quantidade que deseja: ");
            string[] produto = Console.ReadLine().Split(' ');
            int codigo = int.Parse(produto[0]);
            int quantidade = int.Parse(produto[1]);
            double total = 0;

            if (codigo == 1)
            {
                total = quantidade * 4.00;
            }
            else if (codigo == 2)
            {
                total = quantidade * 4.50;
            }
            else if (codigo == 3)
            {
                total = quantidade * 5.00;
            }
            else if (codigo == 4)
            {
                total = quantidade * 2.00;
            }
            else if (codigo == 5)
            {
                total = quantidade * 1.50;
            }
            else
            {
                Console.WriteLine("Código inválido.");
            }

            Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}