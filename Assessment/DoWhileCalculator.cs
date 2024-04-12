using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class DoWhileCalculator
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            string ch;

            do
            {
                Console.WriteLine("1.Add\n 2.Sub\n 3.Multi\n 4.Div\n 5.Mod");
                Console.WriteLine("Enter the choice from Menu");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add= " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("Sub= " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("Multi= " + (num1 * num2));
                        break;
                    case 4:
                        Console.WriteLine("Div= " + (num1 / num2));
                        break;
                    case 5:
                        Console.WriteLine("Mod= " + (num1 % num2));
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine("Do you want to continue.....Press y to continue");
                ch = Console.ReadLine();

            } while (ch.ToLower() == "y");





        }



    }
}
