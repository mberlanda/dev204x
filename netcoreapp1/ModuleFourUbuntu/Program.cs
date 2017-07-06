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
            student1.firstName = "Hallr";
            student1.lastName = "Waramunt";
            student1.birthday = DateTime.Parse("1980-01-01");
            // Create a struct to represent a teacher
            Practice.Teacher teacher1 = new Practice.Teacher();
            teacher1.firstName = "Albino";
            teacher1.lastName = "Gul";
            teacher1.birthday = DateTime.Parse("1960-01-01");
            // Create a struct to represent a program
            Practice.Program program1 = new Practice.Program();

            Practice.Degree degree1 = new Practice.Degree();
            degree1.category = "a category";
            degree1.creditsRequired = 15;
            degree1.name = "degree name";

            program1.name = "program name";
            program1.departmentHead = String.Join(" ",
                                      new string[] { teacher1.firstName, teacher1.lastName});
            program1.Degrees = new Practice.Degree[] { degree1 } ;

            // Create a struct to represent a course
            Practice.Course course1 = new Practice.Course();
            course1.credits = 15;
            course1.durationInWeeks = 12;
            course1.name = "course name";

            // Create an array to hold 5 student structs.
            Practice.Student[] studentAry = new Practice.Student[5];
            // Assign values to the fields in at least one of the student structs in the array
            studentAry[0] = student1;
            // Using a series of Console.WriteLine() statements, output the values for the student struct that you assigned in the previous step
            foreach(Practice.Student s in studentAry)
            {
                if (s.lastName != null)
                    Console.WriteLine("{0} {1} was born on: {2:D}", s.firstName, s.lastName, s.birthday);
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
