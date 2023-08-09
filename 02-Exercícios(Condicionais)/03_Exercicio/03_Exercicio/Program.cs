namespace _03_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B: ");
            int b = int.Parse(Console.ReadLine());


            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("São Multiplos.");
            }
            else
            {
                Console.WriteLine("Não são Multiplos.");
            }
        }
    }
}