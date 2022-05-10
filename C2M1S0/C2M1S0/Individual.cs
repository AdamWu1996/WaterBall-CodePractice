using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    public class Individual
    {
        public enum Gender
        {
            MALE, FEMALE
        }

        private int id;
        private Gender gender;
        private int age;
        private string intro;
        private string habits;
        private float[] coord;

        public Individual(int id, Gender gender, int age, string intro, string habits, float[] coord)
        {
            this.id=id;
            this.gender=gender;
            this.Age=age;
            this.Intro=intro;
            this.habits=habits;
            this.coord=coord;
        }

        public int Id { get => id; set => id = value; }
        public Gender Gender1 { get => gender; set => gender = value; }
        public int Age { get => age;
            set 
            {
                if (value < 18)
                {
                    Console.WriteLine($"{Id}你未成年歐！888");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                age = value;
            } 
        }
        public string Intro { get => intro;
            set
            {
                if (value.Length > 200)
                {
                    Console.WriteLine($"{Id}字數太長惹！888");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                intro = value;
            } 
        }
        public string Habits { get => habits; set => habits = value; }
        public float[] Coord { get => coord; set => coord = value; }

    }
}
