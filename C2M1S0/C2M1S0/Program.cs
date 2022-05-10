using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2M1S0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Individual memberA = new Individual(123, Individual.Gender.MALE, 30, "你好1", "吃飯,喝咖啡,看書", new float[2] { 5, 4 });
            Individual memberB = new Individual(456, Individual.Gender.MALE, 19, "你好2", "吃飯,喝咖啡,看動物", new float[2] { 8, 1 });
            Individual memberC = new Individual(789, Individual.Gender.MALE, 29, "你好3", "吃甜食,喝咖啡,看動物", new float[2] { 5, 2 });
            Individual memberD = new Individual(7, Individual.Gender.MALE, 49, "你好4", "吃飯,吃甜食,喝咖啡,看動物,吃動物", new float[2] { 2, 7 });

            MatchingSystem matchingSystem = new MatchingSystem(new HabitBased());

            matchingSystem.Apply(memberA);
            matchingSystem.Apply(memberB);
            matchingSystem.Apply(memberC);
            matchingSystem.Apply(memberD);
            matchingSystem.match(memberA);

            Console.ReadKey();
        }
    }
}
