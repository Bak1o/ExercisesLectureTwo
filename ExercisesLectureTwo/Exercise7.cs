using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise7
    {
        public void Exerc7()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());

            if (mathOperator == '+')
            {
                Console.WriteLine(a + b);
            }
            else if (mathOperator == '-')
            {

                Console.WriteLine(a - b);
            }
            else if (mathOperator == '*')
            {

                Console.WriteLine(a * b);
            }
            else if (mathOperator == '/')
            {

                Console.WriteLine(a / b);
            }
            else if (mathOperator == '%')
            {

                Console.WriteLine(a % b);
            }
            else
            {
                Console.WriteLine("try it again");
            }
        }
    }
}
