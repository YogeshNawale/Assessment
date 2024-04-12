
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class DisplayGreatestBetn3Numbers
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second nummber");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine($"The Greatest number is {num1}");
                }
                else
                {
                    Console.WriteLine($"The Greatest number is {num3}");
                }
            }
            else
            {
                if (num2 >= num3)
                {
                    Console.WriteLine($"The Greatest number is {num2}");
                }
                else
                {
                    Console.WriteLine($"The Greatest number is {num3}");
                }
            }

        }



    }
}
