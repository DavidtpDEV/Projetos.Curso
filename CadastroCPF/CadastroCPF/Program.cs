using System;

namespace CadastroCPF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um CPF para validar:");
            string cpf = Console.ReadLine();

            if (CPF.ValidarCPF(cpf))
                Console.WriteLine("CPF válido!");
            else
                Console.WriteLine("CPF inválido!");

            Console.ReadLine();
        }
    }
}
