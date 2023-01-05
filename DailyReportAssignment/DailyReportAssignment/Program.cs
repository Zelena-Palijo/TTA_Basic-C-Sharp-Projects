using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReportAssignment
{
    class Program
    {
        static void Main()
        {
            string str1 = "The Tech Academy \n" +
                "Student Daily Report";
            Console.WriteLine(str1);
            Console.ReadLine();

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pNumber = Convert.ToInt32(pageNumber);
            Console.ReadLine();

            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study?");
            string studyTime = Console.ReadLine();
            int sTime = Convert.ToInt32(studyTime);
            Console.ReadLine();

            string str2 = "Thank you for your ansers. An Instructor will respond to this shortly. \n" +
                "Have a great day!";
            Console.WriteLine(str2);
            Console.ReadLine();

            

        }
    }
}
