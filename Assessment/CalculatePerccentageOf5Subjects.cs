using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class CalculatePerccentageOf5Subjects
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Subject 1 marks");
            int sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Subject 2 marks");
            int sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Subject 3 marks");
            int sub3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Subject 4 marks");
            int sub4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Subject 5 marks");
            int sub5 = Convert.ToInt32(Console.ReadLine());

            double avg= (double)(sub1 + sub2 + sub3 + sub4 + sub5)/5;

            Console.WriteLine($"Percentage of five subject marks is {avg}");


        }
    }
}
