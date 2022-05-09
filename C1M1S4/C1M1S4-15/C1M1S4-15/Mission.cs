using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1M1S4_15
{
    internal class Mission
    {
        private Chapter chapter;
        private List<Scene> scenes;
        private Challenge challenge;

        internal Chapter Chapter { get => chapter; set => chapter = value; }
        internal List<Scene> Scenes { get => scenes; set => scenes = value; }
        internal Challenge Challenge { get => challenge; set => challenge = value; }
    }
}
