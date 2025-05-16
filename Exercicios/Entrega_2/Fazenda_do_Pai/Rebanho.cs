using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2.Fazenda_do_Pai
{
    class Rebanho
    {
        private List<Boi> bois = new List<Boi>();

        public void AdicionarBoi(double peso)
        {
            bois.Add(new Boi(peso));
        }

        public double PesoMedio()
        {
            if (bois.Count == 0)
            {
                Console.WriteLine("Não há bois cadastrados no reanho");
                return 0;
            }
             return bois.Average(boi => boi.GetPeso());   
        }

        public double PesoMax()
        {
            if (bois.Count == 0)
            {
                Console.WriteLine("Não há bois cadastrados no reanho");
                return 0;
            }
            return bois.Max(boi => boi.GetPeso());
        }

        public double PesoMin()
        {
            if (bois.Count == 0)
            {
                Console.WriteLine("Não há bois cadastrados no reanho");
                return 0;
            }
            return bois.Min(boi => boi.GetPeso());
        }

        public void InfoRebanho()
        {
            Console.WriteLine("---Controle do Rebanho---");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"O peso médio do rebanho é de {PesoMedio()}Kg.");
            Console.WriteLine($"O boi mais gordo do rebanho é de {PesoMax()}Kg.");
            Console.WriteLine($"O boi mais magro do rebanho é de {PesoMin()}Kg.");
        }
    }
}
