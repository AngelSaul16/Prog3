﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Clases
{
    class potencia
    {
        public double Potencia(double n1, double n2)
        {
            double p;
            p = Math.Pow(n1, n2);
            return p;
        }
    }
}
