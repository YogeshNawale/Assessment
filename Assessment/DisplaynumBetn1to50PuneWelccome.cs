using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{


    /*  write ccode to display number betn  1 to 50 . At the timme of displaying if number is divisible by 3 then 
	    display "pune" if num s divisible by  5 then display "welcome" and if num s divisible by  3 and 5 then display
	    "welcome to pune"
    */
    public class DisplaynumBetn1to50PuneWelccome
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Welcome to Pune");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Pune");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
