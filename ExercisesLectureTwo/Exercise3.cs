using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise3
    {
        public void Exerc3()
        {
            Console.WriteLine(" enter your score between zero to one hundred");
            int score = int.Parse(Console.ReadLine());

            if (score >= 0 && score < 60)
            { Console.WriteLine($"{score} is Level : F"); }

            else if (score >= 60 && score < 70)

            { Console.WriteLine($"{score} is Level : D"); }

            else if (score >= 70 && score < 80)

            { Console.WriteLine($"{score} is Level : C"); }

            else if (score >= 80 && score < 90)

            { Console.WriteLine($"{score} is Level : B"); }
            else
            {
                Console.WriteLine($"{score} is Level : A");
            }



        }
    }
}
