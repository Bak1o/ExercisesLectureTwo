using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ExercisesLectureTwo;

namespace ExercisesLectureTwo
{

    internal class Exercise1
    {
        public void Exerc1()
        {
            Console.WriteLine("enter the number you want");

           decimal number = decimal.Parse(Console.ReadLine());

            if (number == 0)
            {
                Console.WriteLine($" the number you entered equals to {number}");
            }
            else if (number > 0)
            {
                Console.WriteLine("you entered the positive number");

            }

            else 
            {
                Console.WriteLine("you entered the negative number");
            }
        }
        




    }
}
