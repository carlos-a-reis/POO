using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Entrega_1.Entrega_1
{
    class Banco
    {
        private string Nome;
        private int Codigo;
        private List<Conta> Contas = new List<Conta>();

        public string GetNome() { return Nome; }
        public int GetCodigo() { return Codigo; }
        public List<Conta> GetContas() { return Contas; }

        public Banco(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public void InfoBanco()
        {
            Console.WriteLine($"Banco: {Nome}");
            Console.WriteLine($"Código: {Codigo}");
        }

        public Conta AbrirConta(string numeroAgencia, string numeroConta, string nomeTitular, double saldoInicial)
        {
            Conta novaConta = new Conta(saldoInicial, numeroAgencia, numeroConta, nomeTitular, this);
            Contas.Add(novaConta);

            return novaConta;
        }

        public Conta BuscarConta(string agencia, string numeroConta)
        {
            Conta conta = Contas.FirstOrDefault(c => c.GetNumeroAgencia() == agencia && c.GetNumeroConta() == numeroConta);

            conta.InfoConta();

            return conta;
        }

        public void ListarContas()
        {
            foreach(var conta in Contas)
            {
                conta.InfoConta();
            }
        }
    }
}
