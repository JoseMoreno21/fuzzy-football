using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLABFuzzyFW
{
    public interface IFuzzyFW
    {
        double FindFuzzyFW(double Resistencia, double Velocidad, double Agilidad, double Confianza, double Finalizacion, double Dribbling, double Pases);
    }
}
