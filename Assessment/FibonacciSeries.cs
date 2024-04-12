using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class FibonacciSeries
    {
        static void Main(string[] args)
        {

            int n = 10;
            int firstterm = 0;
            int secondterm = 1;
            Console.WriteLine("0 1 ");
            for (int i = 1; i <= n - 2; i++)
            {
                int nextterm = firstterm + secondterm;
                firstterm = secondterm;
                secondterm = nextterm;

                Console.WriteLine(nextterm + " ");

            }


        }


    }
}
