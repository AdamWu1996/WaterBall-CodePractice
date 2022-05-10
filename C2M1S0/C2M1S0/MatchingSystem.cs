using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    public class MatchingSystem
    {
        private MatchSrategy matchSrategy;
        private List<Individual> preys = new List<Individual>();

        public MatchingSystem(MatchSrategy matchSrategy)
        {
            this.MatchSrategy = matchSrategy;
        }

        public void Apply(Individual individual)
        {
            Preys.Add(individual);
        }

        public void match(Individual individual)
        {
            matchSrategy.MatchMethod(individual, Preys);
        }

        public MatchSrategy MatchSrategy { get => matchSrategy; set => matchSrategy=value; }
        public List<Individual> Preys { get => preys; set => preys=value; }
    }
}
