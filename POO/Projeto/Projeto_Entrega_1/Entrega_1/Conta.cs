using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Entrega_1.Entrega_1
{
    class Conta
    {
        private double Saldo;
        private string NumeroAgencia;
        private string NumeroConta;
        private string NomeTitular;
        private Banco BancoProprietario;

        public double GetSaldo() { return Math.Round(Saldo, 2);}
        public string GetNumeroAgencia() { return NumeroAgencia; }
        public string GetNumeroConta() { return NumeroConta; }
        public string GetNomeTitular() { return NomeTitular; }

        public Conta(double saldo, string numeroAgencia, string numeroConta, string nomeTitular, Banco bancoProprietario)
        {
            Saldo = Math.Round(saldo, 2);
            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            BancoProprietario = bancoProprietario;
        }

        public void InfoConta()
        {
            Console.WriteLine($"Agência: {NumeroAgencia}");
            Console.WriteLine($"Número: {NumeroConta}");
            Console.WriteLine($"Titual: {NomeTitular}");
            Console.WriteLine($"Saldo: R$ {Saldo:F2}");
            BancoProprietario.InfoBanco();
        }

        public void Depositar(double valor)
        {
            double saldoAnterior = Saldo;
            Saldo = Saldo + valor;

            Console.WriteLine($"O saldo anterior era de R$ {saldoAnterior:F2}");
            Console.WriteLine($"O valor do deposito foi de R$ {valor:F2}");
            Console.WriteLine($"O saldo atual é de R$ {Saldo:F2}");
        }

        public void Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                double saldoAnterior = Saldo;
                Saldo = Saldo - valor;

                Console.WriteLine($"O saldo anterior era de R$ {saldoAnterior:F2}");
                Console.WriteLine($"O valor do saque foi de R$ {valor:F2}");
                Console.WriteLine($"O saldo atual é de R$ {Saldo:F2}");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque");
            }
        }
    }
}

