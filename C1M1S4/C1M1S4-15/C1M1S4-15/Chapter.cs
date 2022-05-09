using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1S4_15
{
    internal class Chapter
    {
        private Jouney jouney;
        private List<Mission> missions;

        internal Jouney Jouney { get => jouney; set => jouney = value; }
        internal List<Mission> Missions { get => missions; set => missions = value; }
    }
}
