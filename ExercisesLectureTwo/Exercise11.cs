using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise11
    {
        public void Exerc11()
        {
            var userCurrentCountry = RegionInfo.CurrentRegion;

            
            string userCountry = userCurrentCountry.ToString();
            Console.WriteLine("enter your age to find out whether you are able to buy products or not in your country");

            int userAge = int.Parse(Console.ReadLine());

            if (userCurrentCountry.Equals("US") && userAge >= 21)
            {
                Console.WriteLine($" you are legal to buy products in {userCurrentCountry} country ");
            }
            else if (userCountry != "US" && userAge >= 18)
            {
                Console.WriteLine($" you are legal to buy products in {userCurrentCountry} country ");

            }

            else
            {
                Console.WriteLine($" you are not legal to buy products in {userCurrentCountry} country ");
            }


        }

    }
}
