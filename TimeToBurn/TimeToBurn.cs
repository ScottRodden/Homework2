using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeToBurn
{
    class TimeToBurn
    {
        static void Main(string[] args)
        {
                     
            
            Console.WriteLine("How many calories would you like to burn this workout session?");
            double goal = Convert.ToDouble(Console.ReadLine());

           
            double calories = 3.9;
            int counter = 0;
            Double TotalCal = 0;

            while (TotalCal <= goal)
            {

                counter++;
                TotalCal = counter * calories;
                Console.WriteLine("After " + counter + " minutes, you will have burned " + TotalCal.ToString("N1") + " calories");
                                   
            }
            Console.WriteLine();
            Console.WriteLine("**It will take you " + counter + " minutes to reach your goal of "+ goal + " Calories**");
            Console.ReadKey();


        }
    }
}
