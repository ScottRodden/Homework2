//Scott Rodden

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutor
{
    class Tutor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Addition Practice** \n");
            ;
            
            Random rand = new Random();
            int RanNum1 = rand.Next(1, 50);
            int RanNum2 = rand.Next(1, 50);
           // bool correct = true;
            double answer = RanNum1 + RanNum2;
            double input;

            do
            {
                  Console.WriteLine(RanNum1 + " + " + RanNum2 + " = ");
                  input = Convert.ToDouble(Console.ReadLine());

                  if (input == answer)
                  {

                    Console.WriteLine("\n" + "Congratulations you are a genius! \n");
                 
                  }
                  else
                  {

                    Console.WriteLine("Wrong. Please Try Again");
                 
                  }

                                
            } while (answer != input);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
