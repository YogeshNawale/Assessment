using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class SumOfEvenNumberBetn1To20
    {
        static void Main(string[] args)
        {


            int i = 1;
            int sum = 0;

            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
                i++;
            }
            Console.WriteLine($" the sum of Even numbers between 1 to 20 is {sum}");




    }
    }
}
