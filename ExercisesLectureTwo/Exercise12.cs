using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise12
    {
        public void Exerc12()
        {
            Console.WriteLine(" if you want to use our credit first enter your age ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter your annual income ");
            decimal AnnualIncome = decimal.Parse(Console.ReadLine());

            if (AnnualIncome >= 25000 && age >= 18)
            {
                Console.WriteLine(" you can use our credit ");
            }
            else if (AnnualIncome < 25000 && age >= 18)
            {
                Console.WriteLine(" do you have guarantors? answer : YES or No");
                string answer = Console.ReadLine();
                if (answer == "YES")
                {
                    Console.WriteLine(" you can use our credit ");
                }
                else
                {
                    Console.WriteLine(" you can not use our credit");
                }

            }
            else {
                Console.WriteLine(" you can not use our credit ");
                    }

        }

    }
}
