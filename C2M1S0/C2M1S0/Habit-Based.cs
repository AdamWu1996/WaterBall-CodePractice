using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    public class HabitBased : MatchSrategy
    {
        public void MatchMethod(Individual me, List<Individual> preys)
        {
            int habitsMatchMaxTimes = 0;
            Individual match = null;

            foreach (Individual prey in preys)
            {
                int habitsMatchTimes = 0;
                string[] preyHabits = prey.Habits.Split(',');
                string[] myHabits = me.Habits.Split(',');

                if (me.Id != prey.Id)
                {
                    for (int i = 0; i < myHabits.Length; i++)
                    {
                        for (int j = 0; j < preyHabits.Length; j++)
                        {
                            if (preyHabits[j].Contains(myHabits[i]))
                            {
                                ++habitsMatchTimes;
                                break;
                            }
                        }
                    }

                    if (habitsMatchMaxTimes < habitsMatchTimes)
                    {
                        habitsMatchMaxTimes = habitsMatchTimes;
                        match = prey;
                    }
                    else if (habitsMatchMaxTimes == habitsMatchTimes)
                    {
                        match = prey.Id < match.Id ? prey : match;
                    }
                }
            }

            Console.WriteLine($"和ID:{match.Id}配對成功");
            Console.WriteLine($"你的興趣:{me.Habits}");
            Console.WriteLine($"他的興趣:{match.Habits}");
            Console.WriteLine($"興趣交集次數:{habitsMatchMaxTimes}");
        }
    }
}
