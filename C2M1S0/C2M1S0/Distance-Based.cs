using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C2M1S0
{
    public class Distance_Based : MatchSrategy
    {
        public void MatchMethod(Individual me, List<Individual> preys)
        {
            double minmumDistance = double.MaxValue;

            foreach (Individual prey in preys)
            {
                if(GetDistance(me, prey) < minmumDistance)
                {
                    minmumDistance = GetDistance(me, prey);
                }

            }
        }

        public double GetDistance(Individual me, Individual prey)
        {
            return Math.Sqrt(Math.Pow(me.Coord[0] - prey.Coord[0], 2) + Math.Pow(me.Coord[1] - prey.Coord[1], 2));
        }
    }
}
