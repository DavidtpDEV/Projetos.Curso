using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituicaoPagamentos.Models
{
    public class Conta
    {
        public Cliente Cliente { get; set; }
        public decimal Saldo { get; set; }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado com sucesso para {Cliente.Nome}. Novo saldo: {Saldo:C}");
        }

        public bool Sacar(decimal valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine($"Saldo insuficiente para saque de {valor:C}. Saldo atual: {Saldo:C}");
                return false;
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso para {Cliente.Nome}. Novo saldo: {Saldo:C}");
                return true;
            }
        }
    }
}
