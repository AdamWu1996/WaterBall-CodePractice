using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace C2M1S0
{
    public class DistanceBased : MatchSrategy
    {
        public void MatchMethod(Individual me, List<Individual> preys)
        {
            double minmumDistance = double.MaxValue;
            Individual match = null;

            foreach (Individual prey in preys)
            {
                double distance = GetDistance(me, prey);
                if (distance < minmumDistance && me.Id != prey.Id)
                {
                    minmumDistance = distance;
                    match = prey;
                }
            }

            Console.WriteLine($"和ID:{match.Id}配對成功");
            Console.WriteLine($"{me.Id}座標:({me.Coord[0]},{me.Coord[1]})");
            Console.WriteLine($"{match.Id}座標:({match.Coord[0]},{match.Coord[1]})");
            Console.WriteLine($"距離:{minmumDistance}");

        }

        public double GetDistance(Individual me, Individual prey)
        {
            return Math.Sqrt(Math.Pow(me.Coord[0] - prey.Coord[0], 2) + Math.Pow(me.Coord[1] - prey.Coord[1], 2));
        }
    }
}
