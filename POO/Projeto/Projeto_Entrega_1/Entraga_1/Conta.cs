using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Entrega_1.Entraga_1
{
    class Conta
    {
        private double Saldo { get { return Saldo; } set { }}
        private int NumeroAgencia { get; set; }
        private int NumeroConta { get; set; }
        private string NomeTitular { get; set; }

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
