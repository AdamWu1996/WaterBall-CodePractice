using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 參考水球UML
{
    internal class MissionCarryOn
    {
        private State status = State.ONGOING;
        private Student student;
        private Mission mission;

        public MissionCarryOn(Student student, Mission mission)
        {
            this.student = student;
            this.mission = mission;
        }

        public enum State
        {
            ONGOING, COMPLETED
        }
    }
}
