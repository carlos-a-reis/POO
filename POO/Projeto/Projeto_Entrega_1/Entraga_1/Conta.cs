using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Entrega_1.Entraga_1
{
    class Conta
    {
        private double Saldo;
        private int NumeroAgencia;
        private int NumeroConta;
        private string NomeTitular;

        public double GetSaldo() { return Math.Round(Saldo, 2);}
        public int GetNumeroAgencia() { return NumeroAgencia; }
        public int GetNumeroConta() { return NumeroConta; }
        public string GetNomeTitular() { return NomeTitular; }

        public Conta(double saldo, int numeroAgencia, int numeroConta, string nomeTitular)
        {
            Saldo = Math.Round(saldo, 2);
            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }

        public void Depositar(double valor)
        {
            double saldoAnterior = Saldo;
            Saldo = Saldo + valor;

            Console.WriteLine($"O saldo anterior era de R$ {saldoAnterior:F2}");
            Console.WriteLine($"O saldo atual é de R$ {Saldo:F2}");
        }
    }
}

