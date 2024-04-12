using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class FirstProgram
    {
        // main is not public method
        // Main() M is capital letter in c# as it uses capital case for method writing while java uses camel case for method writing

        static void Main(string[] args) {

            Console.WriteLine("Enter First number");
            int num1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int num2= Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"Addition is {sum}");

        }
        
    }
}
