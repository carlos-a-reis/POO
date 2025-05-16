using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega_2.Notas_Disciplina
{
    class Nota
    {
        private List<double> notas;

        public Nota()
        {
            notas = new List<double>();
        }

        public void AdicionarNota(double nota)
        {
            if (nota >= 0 && nota <= 10.0)
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Nota deve estar entre 0 e 10.0.");
            }
        }

        public double CalcularMediaFinal()
        {
            if (!notas.Any()) return 0;
            return notas.Average();
        }

        public string ObterStatusAprovacao()
        {
            double media = CalcularMediaFinal();

            if (media > 7.0)
            {
                return "Aprovado!";
            }
            else if (media >= 4.0 && media <= 7.0)
            {
                double falta = 7.0 - media;
                return $"Em recuperação. Faltam {falta:F2} pontos para passar.";
            }
            else
            {
                return "Reprovado.";
            }
        }
    }
}
