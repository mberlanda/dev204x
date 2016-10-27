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
            GetUProgramInformation();
            GetDegreeInformation();

            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }


        // Student Information
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


        // Teacher Information
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

        // UProgram Information
        static void GetUProgramInformation()
        {
            Console.WriteLine("Enter the uprogram's name: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the uprogram's department head: ");
            string departmentHead = Console.ReadLine();
            Console.WriteLine("Enter the uprogram's degrees: ");
            string degrees = Console.ReadLine();

            // print uprogram details
            PrintUProgramDetails(programName, departmentHead, degrees);
        }

        static void PrintUProgramDetails(string name, string department, string degrees)
        {
            Console.WriteLine("The program {0} in {1} department offers {2} degrees", name, department, degrees);
        }

        // Degree Information
        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the degree's name: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the degree's credits required: ");
            try
            {
                int creditsRequired = Convert.ToInt32(Console.ReadLine());
                // print degree details
                PrintDegreeDetails(degreeName, creditsRequired);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e);
            }
        }

        static void PrintDegreeDetails(string name, int creditsRequired)
        {
            Console.WriteLine("{0} requires {1} credits.", name, creditsRequired);
        }
        //Course Information
        //string courseName;
        //int credits;
        //int durationInWeeks;
        //string teacher;
    }
}
