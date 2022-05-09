using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLABFuzzyMC
{
    public interface IFuzzyMC
    {
        double FindFuzzyMC(double TomaDecisiones, double Resistencia, double Agilidad, double Confianza, double Creatividad, double Pases);
    }
}
