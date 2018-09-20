//Scott Rodden
//Sources: Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionIncrease
{
    class TuitionIncrease
    {
        static void Main(string[] args)
        {
            double total;
            double tuition = 12000;
            double interest = 0.05;
            Console.WriteLine("**Tuition Increase per year** \n");
            
        

            for (int i = 1; i < 8; i++)
            {

                total = tuition * (1 + interest);
                tuition = total;
                Console.WriteLine("The tuition for year " + i +" will be " + total.ToString("C0") + "\n");

            }

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();




        }
    }
}
