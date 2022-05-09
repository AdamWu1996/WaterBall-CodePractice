using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 參考水球UML
{
    public class Student
    {
        private static readonly LevelSheet LEVEL_SHEET = new LevelSheet();
        private int exp;
        private int level = 1;
        private string account;
        private string password;
        private List<MissionCarryOn> missionCarryOns;
        private List<Adventure> adventures;


        public Student(string account, string password)
        {
            this.account = account;
            this.password = password;
        }

        public int Exp { get => exp; }
        public int Level { get => level; }
        public string Account { get => account; }
        public List<Adventure> Adventures { get => adventures; set => adventures = value; }

        public void gainExp(int exp)
        {
            this.exp += exp;
            int newLevel = LEVEL_SHEET.query(this.exp);
            int levelUp = newLevel - level;
            Console.WriteLine($"獲得{exp}經驗值");
            for(int i = 0; i < levelUp; i++)
            {
                this.levelUp();
            }
        }

        public void levelUp()
        {

        }

        public void carryOn(Mission mission)
        {
            MissionCarryOn missionCarryOn = new MissionCarryOn(this, mission);
            missionCarryOns.Add(missionCarryOn);
        }
    }
}
