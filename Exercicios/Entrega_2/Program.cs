using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entrega_2.Fazenda_do_Pai;

namespace Entrega_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício Fazenda do Pai
            Console.WriteLine("Rebanho da Fazenda da Pai");
            Console.WriteLine("-------------------------");

            Rebanho rebanho = new Rebanho();

            while (true)
            {
                Console.WriteLine("Digite o peso do boi em quilogramas (ou digite 0 para encerrar o programa)");
                string resposta = Console.ReadLine();

                if (double.TryParse(resposta, out double pesoBoi))
                {
                    if (pesoBoi == 0)
                    {
                        Console.WriteLine("Programa encerrado");
                        break;
                    }
                    if (pesoBoi < 0)
                    {
                        Console.WriteLine("Peso inváliodo. Tente novamente");
                    }
                    else
                    {
                        rebanho.AdicionarBoi(pesoBoi);
                        Console.WriteLine($"Boi de peso {pesoBoi}Kg adicionado");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido. Digite um número para o peso do boi.");
                }
            }

            rebanho.InfoRebanho();
        }
    }
}
