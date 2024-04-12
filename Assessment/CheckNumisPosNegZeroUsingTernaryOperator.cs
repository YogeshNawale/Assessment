using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class CheckNumisPosNegZeroUsingTernaryOperator
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            string result = (num > 0) ? "Positive" : (num < 0) ? "Negative" : "Zero";

            Console.WriteLine($"The number is {result}.");



        }
    }
}
