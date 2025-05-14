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

        public double getSaldo() { return Saldo;}
        public int getNumeroAgenci() { return NumeroAgencia; }
        public double getNumeroConta() { return NumeroConta; }
        public string getNomeTitular() { return NomeTitular; }


        public Conta(double saldo, int numeroAgencia, int numeroConta, string nomeTitular)
        {
            Saldo = saldo;
            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
        }
    }
}
