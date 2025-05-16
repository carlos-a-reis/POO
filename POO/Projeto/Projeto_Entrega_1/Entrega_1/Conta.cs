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
            try
            {
                if(saldo > 0)
                {
                    Saldo = Math.Round(saldo, 2);
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Saldo), "O saldo inicial deve ser maior que R$ 0.00");
                }

                NumeroAgencia = numeroAgencia;
                NumeroConta = numeroConta;
                NomeTitular = nomeTitular;
                BancoProprietario = bancoProprietario;
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine($"\nOcorreu um erro ao criar a nova conta: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"\nErro inespera ao criar nova conta: {error.Message}");
            }
        }

        public void InfoConta()
        {
            Console.WriteLine($"\nAgência: {NumeroAgencia}");
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
            try
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
                    throw new ArgumentOutOfRangeException(nameof(Saldo), "O valor do saque não pode ser maior que o saldo da conta");
                }
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine($"\nOcorreu um erro ao realizar o saque: {error.Message}");
            }
            
        }
    }
}

