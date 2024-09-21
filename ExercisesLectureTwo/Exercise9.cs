using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesLectureTwo
{
    internal class Exercise9
    {
        public void Exerc9()
        {
            DateTime dt = new DateTime(2023,09,21,05,00,00);
            DateTime dt1 = new DateTime(2023, 09, 21, 12, 00, 00); 
            DateTime dt2 = new DateTime(2023, 09, 21, 17, 00, 00);
            DateTime dt3 = new DateTime(2023, 09, 21, 21, 00, 00); 

            DateTime local = DateTime.Now;

            if (local.Hour >= dt.Hour && local.Hour < dt1.Hour)
            {
                Console.WriteLine(" good morning ");
            }

            else if (local.Hour >= dt1.Hour && local.Hour < dt2.Hour)
            {
                Console.WriteLine(" good afternoon ");
            }
            else if (local.Hour >= dt2.Hour && local.Hour < dt3.Hour)
            {
                Console.WriteLine(" good evening ");
            }
            else
            {
                Console.WriteLine(" good night ");
            }
        }
        
    }
}
