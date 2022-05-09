using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLABFuzzyDC
{
    public interface IFuzzyDC
    {
        double FindFuzzyDC(double Altura, double Peso, double Musculatura, double TomaDecisiones, double Concentracion, double Resistencia);
    }
}