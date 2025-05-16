using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2.Engine_do_Unity
{
    class Engine
    {
        private int TempoGasto;
        private double VelocidadeMedia;

        public Engine(int tempoGasto, double velocidadeMedia)
        {
            if(tempoGasto <= 0 || velocidadeMedia <= 0)
            {
                Console.WriteLine("Valores inválidos");
            }
            else
            {
                TempoGasto = tempoGasto;
                VelocidadeMedia = velocidadeMedia;
            }
        }

        public double CalculoDistancia() { return TempoGasto * VelocidadeMedia; }

        public double CalculoConsumo(double litros) { return CalculoDistancia() / litros; }
    }
}
