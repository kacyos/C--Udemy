namespace _01_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("Não negativo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}