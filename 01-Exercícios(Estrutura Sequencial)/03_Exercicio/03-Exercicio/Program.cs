namespace _03_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, DIFERENCA;

            Console.Write("Informe o valor de A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de B: ");
            B = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de C: ");
            C = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de D: ");
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);

            Console.ReadKey();

        }
    }
}