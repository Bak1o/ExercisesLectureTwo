using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise2
    {
        public void Exerc2()
        {
            Console.WriteLine("enter the whole number");
            double numb = double.Parse(Console.ReadLine());
            if (numb % 1 == 0 && numb % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else if (numb % 1 == 0 && !(numb % 2 == 0))
            {
                Console.WriteLine("number is odd");
            }

            else
            {
                Console.WriteLine(" enter the correct number");
            }
        }
    }
}
