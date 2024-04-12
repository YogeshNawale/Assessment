using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public class DisplayPerccentageGradeFor5Subjects
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter marks for 5 subjects:");

            
            Console.Write("Subject 1: ");
            int subject1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 2: ");
            int subject2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 3: ");
            int subject3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 4: ");
            int subject4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Subject 5: ");
            int subject5 = Convert.ToInt32(Console.ReadLine());

            int totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;

            double percentage = (double)totalMarks / 5;

            Console.WriteLine($"Percentage: {percentage}%");

            
            char grade;

            if (percentage >= 90)
            {
                grade = 'A';
            }
            else if (percentage >= 80)
            {
                grade = 'B';
            }
            else if (percentage >= 70)
            {
                grade = 'C';
            }
            else if (percentage >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

           
            Console.WriteLine($"Grade: {grade}");
        

    }


    }
}
