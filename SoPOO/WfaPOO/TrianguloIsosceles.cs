using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaPOO
{
    public class TrianguloIsosceles : Triangulo
    {
        public override double CalcularArea()
        {
            return A * B / 2;
        }

        public override double CalcularPerimetro()
        {
            return B + 2 * Math.Sqrt((B / 2) * (B / 2) + A * A);
        }

        public override string ToString()
        {
            return $"Triângulo Isósceles ({B};{A})";
        }
    }
}
