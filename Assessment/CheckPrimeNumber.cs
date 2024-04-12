using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class CheckPrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isprime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isprime = false;
                    break;
                }
            }
            if (isprime == true)
            {
                Console.WriteLine("number is prime");
            }
            else
                Console.WriteLine("number is not prime");


    }
    }
}
