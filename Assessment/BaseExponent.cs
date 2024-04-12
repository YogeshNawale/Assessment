using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class BaseExponent
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the base number");
            int base1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the exponent number");
            int expo = Convert.ToInt32(Console.ReadLine());


            int power = 1;
            for (int i = 0; i < expo; i++) { 
                power=power*base1;
            }

            Console.WriteLine($" Base {base1}  to the power of exponent {expo} = {power}");

        }

    }
}
