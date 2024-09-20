using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfaPOO
{
    public abstract class Triangulo : FormaGeometrica
    {
        private double a;

        public double A
        {
            get { return a; }
            set { a = value; }
        }

        private double b;

        public double B
        {
            get { return b; }
            set { b = value; }
        }

        private double lado;

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

    }
}
