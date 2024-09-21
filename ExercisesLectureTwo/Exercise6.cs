using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise6
    {
        public void Exerc6()
        {
            Console.WriteLine(" enter three numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Max(c, a);
            int e = int.Max(d, b);

            if (e > d)
            {
                Console.WriteLine($" max value is {e}");

            }
            else if (e < d)
            {
                Console.WriteLine($" max value is {d}");
            }
            else
            {
                Console.WriteLine($" max value is {d}");
            }
        
        }
    }
}
