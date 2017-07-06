using System;

namespace ModuleFourUbuntu
{
    class Program
    {
        static void Main(string[] args)
        {
            // runDemos();
            runPractice();
        }

        static void runPractice()
        {
            // Create a struct to represent a student
            Practice.Student student1 = new Practice.Student();
            student1.FirstName = "Hallr";
            student1.LastName = "Waramunt";
            student1.Birthday = DateTime.Parse("1980-01-01");
            // Create a struct to represent a teacher
            Practice.Teacher teacher1 = new Practice.Teacher();
            teacher1.FirstName = "Albino";
            teacher1.LastName = "Gul";
            teacher1.Birthday = DateTime.Parse("1960-01-01");
            // Create a struct to represent a program
            Practice.Program program1 = new Practice.Program();

            Practice.Degree degree1 = new Practice.Degree();
            degree1.Category = "a category";
            degree1.CreditsRequired = 15;
            degree1.Name = "degree name";

            program1.Name = "program name";
            program1.DepartmentHead = String.Join(" ",
                                      new string[] { teacher1.FirstName, teacher1.LastName});
            program1.Degrees = new Practice.Degree[] { degree1 } ;

            // Create a struct to represent a course
            Practice.Course course1 = new Practice.Course();
            course1.Credits = 15;
            course1.DurationInWeeks = 12;
            course1.Name = "course name";

            // Create an array to hold 5 student structs.
            Practice.Student[] studentAry = new Practice.Student[5];
            // Assign values to the fields in at least one of the student structs in the array
            studentAry[0] = student1;
            // Using a series of Console.WriteLine() statements, output the values for the student struct that you assigned in the previous step
            foreach(Practice.Student s in studentAry)
            {
                if (!String.IsNullOrWhiteSpace(s.LastName))
                    Console.WriteLine($"{s.FirstName} {s.LastName} was born on: {s.Birthday:D}");
            }
        }

        static void runDemos()
        {
            Demo.ArrayDemo();
            Demo.EnumDemo();
            Demo.StructDemo();
        }
    }
}
