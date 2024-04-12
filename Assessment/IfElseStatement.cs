using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class IfElseStatement
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"{num1} is greater than {num2}");
            }
            else
            {
                Console.WriteLine($"{num2} is greater than {num1}");
            }


        }

    }
}
