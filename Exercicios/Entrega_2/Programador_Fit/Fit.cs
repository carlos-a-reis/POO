using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2.Programador_Fit
{
    class Fit
    {
        private double Altura;
        private char Sexo;

        public Fit(double altura, char sexo)
        {
            if (Sexo != 'M' || Sexo != 'F')
            {
                Console.WriteLine("Sexo inválido. Utilize 'M' para masculino ou 'F' para feminino.");
            }
            else
            {
                Altura = altura;
                Sexo = char.ToUpper(sexo);
            }
        }

        public double CalcularPesoIdeal()
        {
            if (Sexo == 'M')
            {
                return (72.7 * Altura) - 58;
            }
            return (62.1 * Altura) - 44.7;
        }
    }
}
