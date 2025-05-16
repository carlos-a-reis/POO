using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2.Fazenda_do_Pai
{
    class Boi
    {
        private double Peso;

        public double GetPeso() { return Peso; }

        public Boi(double peso)
        {
            try
            {
                if (peso <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Peso), "O peso do boi deve ser maior que 0 Kg");
                }
                else
                {
                    Peso = peso;
                    Console.WriteLine($"\nBoi de peso {Peso} Kg cadastrado");
                }
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine($"\nOcorreu ao cadastrar um novo boi: {error.Message}");
            }
            
        }
    }
}
