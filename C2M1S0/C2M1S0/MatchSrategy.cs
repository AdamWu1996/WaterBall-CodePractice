using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    public interface MatchSrategy
    {
        void MatchMethod(Individual me, List<Individual> preys);
    }
}
