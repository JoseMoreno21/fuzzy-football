using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLABFuzzyPT
{
    public interface IFuzzyPT
    {
        double FindFuzzyPT(double Altura, double Peso, double Musculatura, double TomaDecisiones, double Agilidad, double Confianza);
    }
}
