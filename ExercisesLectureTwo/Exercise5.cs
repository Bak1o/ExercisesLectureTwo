using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise5
    {
        public void Exerc5()
        {
            Console.WriteLine(" enter the password ");
            string password = Console.ReadLine();

            Console.WriteLine(" confirm the password");
            string confirmPassword = Console.ReadLine();

            if (password.Equals(confirmPassword))
            {
                Console.WriteLine(" Access Granted ");

            }
            else
            {
                Console.WriteLine(" Access Forbidden ");
            }
        }
    }
}
