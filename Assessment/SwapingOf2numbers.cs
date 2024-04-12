using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class SwapingOf2numbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int temp = num1;
            num1= num2;
            num2= temp;

            Console.WriteLine($" First Number is {num1} and Second number is {num2}");



        }


    }
}
