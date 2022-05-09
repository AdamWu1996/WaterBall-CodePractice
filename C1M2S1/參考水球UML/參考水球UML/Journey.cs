using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 參考水球UML
{
    public class Journey
    {
        private char[] description;
        private char[] name;
        private Money price;
        private List<Chapter> chapters;
        private List<Adventure> adventures;

        public Adventure join(Student student)
        {
            int number = adventures.Count + 1;
            Adventure adventure = new Adventure(number, student, this);
            adventures.Add(adventure);
            student.Adventures.Add(adventure);

            Mission firstMission = getFirstMission();
            adventure.Student.carryOn(firstMission);

            return adventure;
        }

        private Mission getFirstMission()
        {
            return chapters[0].Missions[0];
        }
    }
}
