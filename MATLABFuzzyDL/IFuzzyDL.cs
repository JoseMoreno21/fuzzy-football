using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATLABFuzzyDL
{
    public interface IFuzzyDL
    {
        double FindFuzzyDL(double Resistencia, double Velocidad, double Agilidad, double Pases);
    }
}
