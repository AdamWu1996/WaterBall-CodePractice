using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    public class Individual
    {
        private int id;
        private Gender gender;
        private int age;
        private string intro;
        private string habits;
        private float[] coord;

        public int Id { get => id; set => id = value; }
        public Gender Gender1 { get => gender; set => gender = value; }
        public int Age { get => age;
            set 
            {
                if (value < 18)
                {
                    Console.WriteLine("你未成年歐！");
                    return;
                }
                age = value;
            } 
        }
        public string Intro { get => intro;
            set
            {
                if (value.Length > 200)
                {
                    Console.WriteLine("字數太長惹！");
                    return;
                }
                intro = value;
            } 
        }
        public string Habits { get => habits; set => habits = value; }
        public float[] Coord { get => coord; set => coord = value; }

        public enum Gender
        {
            MALE, FEMALE
        }
    }
}
