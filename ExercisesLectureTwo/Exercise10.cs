using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise10
    {
        public void Exerc10()
        {
            Console.WriteLine(" enter the total price of products you are about to buy");
            decimal price = decimal.Parse(Console.ReadLine());
            decimal offPrice;

            if (price > 0 && price < 100)

            {
                Console.WriteLine($" your total cost is {price}");
            }

            else if (price >= 100 && price <= 500)
            {
                offPrice = (price * 10) / 100;
                price = price - offPrice;
                Console.WriteLine($" your total cost is {price}");

            }

            else if (price > 500)
            {
                offPrice = (price * 20) / 100;
                price = price - offPrice;
                Console.WriteLine($" your total cost is {price}");
            }

            else
            {
                Console.WriteLine("enter total amount");
            }




        }
    }
}
