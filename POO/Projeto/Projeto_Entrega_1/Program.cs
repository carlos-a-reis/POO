using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_Entrega_1.Entrega_1;

namespace Projeto_Entrega_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta(100, 123, 456, "carlos");

            Console.WriteLine(conta1.GetSaldo());
            conta1.Depositar(60.00);
            Console.WriteLine(conta1.GetSaldo());
        }
    }
}
