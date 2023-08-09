using System.Globalization;

namespace _04_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Informe o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor por hora: U$ ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * valorHora;

            Console.WriteLine($"\nNumero: {numero}\nSalário: U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}