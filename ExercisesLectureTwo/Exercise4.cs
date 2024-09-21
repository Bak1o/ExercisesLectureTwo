using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise4
    {
        public void Exerc4()
        {
            Console.WriteLine(" enter the year ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && !(year % 100 == 0) && !(year % 400 == 0))
            {
                Console.WriteLine($" {year} year is nakiani");
            }
            else
            {
                Console.WriteLine($" {year} year isn't nakiani");
            }
        }
    }
}
