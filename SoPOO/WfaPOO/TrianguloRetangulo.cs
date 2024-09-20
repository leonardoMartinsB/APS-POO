using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaPOO
{
    public class TrianguloRetangulo : Triangulo
    {
        public override double CalcularArea()
        {
            return A * B / 2;
        }

        public override double CalcularPerimetro()
        {
            return A + B + Math.Sqrt(A * A + B * B);
        }

        public override string ToString()
        {
            return $"Triângulo Reto ({B};{A})";
        }
    }
}
