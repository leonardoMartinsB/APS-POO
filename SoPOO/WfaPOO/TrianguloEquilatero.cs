using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaPOO
{
    public class TrianguloEquilatero : Triangulo
    {
        public override double CalcularArea()
        {
            return Lado * Math.Sqrt(Lado * Lado - Lado / 2 * Lado / 2) / 2;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 3;
        }

        public override string ToString()
        {
            return $"Triângulo Equilátero ({Lado})";
        }
    }
}
