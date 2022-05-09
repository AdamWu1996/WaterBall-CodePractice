using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 參考水球UML
{
    internal abstract class Scene
    {
        private char[] name;
        private int number;

        public abstract int calcExp();
    }
}
