namespace _01_Exercício
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex = 0;

            while (ex == 0)
            {
                int senha = 2002;
                Console.Write("Informe a senha: ");
                int senhaInformada = int.Parse(Console.ReadLine());
                if (senhaInformada == senha)
                {
                    Console.WriteLine("Acesso Permitodo");
                    ex++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Senha inválida.");
                }
            }
        }
    }
}