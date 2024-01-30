using InstituicaoPagamentos.Models;
using System;

namespace InstituicaoPagamentos.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um cliente
            Cliente cliente1 = new Cliente { Nome = "João", CPF = "123.456.789-10" };

            // Criando uma conta para o cliente
            Conta conta1 = new Conta { Cliente = cliente1, Saldo = 1000 };

            // Realizando operações na conta
            conta1.Depositar(500);
            conta1.Sacar(200);
            conta1.Sacar(1500); // Isso deve gerar uma mensagem de saldo insuficiente

            // Registrando uma transação
            Transacao transacao1 = new Transacao { Data = DateTime.Now, Descricao = "Compra", Valor = 300 };
            Console.WriteLine($"Transação registrada em {transacao1.Data}: {transacao1.Descricao} de {transacao1.Valor:C}");

            Console.ReadLine();
        }
    }
}
