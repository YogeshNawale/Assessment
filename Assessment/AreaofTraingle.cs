using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class AreaofTraingle
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the base");
            int base1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height");
            int height = Convert.ToInt32(Console.ReadLine());

            double area = (double)0.5 * base1 * height;

            Console.WriteLine($"Area of circle is {area}");



        }
    }
}
