using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{
    class Program
    {
        static void Main(string[] args)
        {
            GetStudentInformation();
            GetTeacherInformation();

            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }

        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            string birthday = Console.ReadLine();
            // print student details
            PrintStudentDetails(firstName, lastName, birthday);
        }

        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday");
            string birthday = Console.ReadLine();
            // print teacher details
            PrintTeacherDetails(firstName, lastName, birthday);
        }

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }
    }
}
