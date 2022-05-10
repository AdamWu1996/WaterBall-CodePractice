using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    public class DistanceBasedReverse : MatchSrategy
    {
        public void MatchMethod(Individual me, List<Individual> preys)
        {
            double maxmumDistance = 0;
            Individual match = null;

            foreach (Individual prey in preys)
            {
                if (GetDistance(me, prey) > maxmumDistance && me.Id != prey.Id)
                {
                    maxmumDistance = GetDistance(me, prey);
                    match = prey;
                }
            }

            Console.WriteLine($"和ID:{match.Id}配對成功");
            Console.WriteLine($"{me.Id}座標:({me.Coord[0]},{me.Coord[1]})");
            Console.WriteLine($"{match.Id}座標:({match.Coord[0]},{match.Coord[1]})");
            Console.WriteLine($"距離:{maxmumDistance}");
        }

        public double GetDistance(Individual me, Individual prey)
        {
            return Math.Sqrt(Math.Pow(me.Coord[0] - prey.Coord[0], 2) + Math.Pow(me.Coord[1] - prey.Coord[1], 2));
        }
    }
}
