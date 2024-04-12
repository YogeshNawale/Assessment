using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class CountOddNumber
    {
        static void Main(string[] args)
        {

            int i;
            int count = 0;

            for (i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    count = count + 1;
                }
            }
            Console.WriteLine($"count of odd numbers betn 1 to 10 is {count}");
     




        }

    }
}
