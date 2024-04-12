using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class AreaofCircle
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the radius");
            int rad= Convert.ToInt32(Console.ReadLine());
            double area = (double)3.1416 * rad * rad;

            Console.WriteLine($"Area of circle is {area}");

            // git.........
        }
    }
}
