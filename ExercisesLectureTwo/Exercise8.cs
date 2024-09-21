using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise8
    {
        public void Exerc8()
        {
            Console.WriteLine(" enter your age ");
            byte age = byte.Parse(Console.ReadLine());

            if (age >= 18 && age < 140)
            {
                Console.WriteLine(" you're legal to vote in election");
            }
            else if (age < 18)
            {
                Console.WriteLine(" you're uder age to vote in election");
            }
            else
            {
                Console.WriteLine(" enter your correct age");
            }
        }
    }
}
