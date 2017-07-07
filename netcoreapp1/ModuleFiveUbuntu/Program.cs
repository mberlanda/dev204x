using System;
using System.Linq;

namespace ModuleFiveUbuntu
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunDemos();
            RunAssignment();
        }
        static void RunDemos(){
            Demo.DrinksMachineDemo();
            Demo.ConversionsDemo();
            Demo.AnonymousDemo();
        }
        static void RunAssignment()
        {
            // Instantiate three Student objects.
            Student student1 = new Student("Hallr", "Waramunt", DateTime.Parse("1980-01-01"));
            Student student2 = new Student("Paulinus", "Meine", DateTime.Parse("1983-01-01"));
            Student student3 = new Student("Benjamín", "Fintan", DateTime.Parse("1985-01-01"));
            // Instantiate a Course object called Programming with C#.
            Course course1 = new Course("Programming with C#");
            Course course2 = new Course("Advanced Programming with C#");
            // Add your three students to this Course object.
            course1.Students = new Student[] { student1, student2, student3 };
            course2.Students = new Student[] { student2, student3 };
            // Instantiate at least one Teacher object.
            Teacher teacher1 = new Teacher("Mehmed", "Ianto", DateTime.Parse("1960-01-01"));
            Teacher teacher2 = new Teacher("Tonio", "Arash", DateTime.Parse("1965-01-01"));
            // Add that Teacher object to your Course object
            course1.Teachers = new Teacher[] { teacher1 };
            course2.Teachers = new Teacher[] { teacher1, teacher2 };
            // Instantiate a Degree object, such as Bachelor.
            Degree degree1 = new Degree("Bachelor");
            Degree degree2 = new Degree("Master");
            // Add your Course object to the Degree object.
            degree1.Courses = new Course[] { course1 };
            degree2.Courses = new Course[] { course2 };
            // Instantiate a UProgram object called Information Technology.
            UProgram program1 = new UProgram("Information Technology");
            // Add the Degree object to the UProgram object.
            program1.Degrees = new Degree[] { degree1, degree2 };
            /*
            Using Console.WriteLine statements, output the following information to the console window:
                The name of the program and the degree it contains
                The name of the course in the degree
                The count of the number of students in the course.
            */
            PrintUProgramDetails(program1);
        }

        static void PrintUProgramDetails(UProgram uprogram)
        {
            Console.WriteLine(
                $"The {uprogram.Name} program contains the following degrees: {String.Join(", ", uprogram.Degrees.Select(d => d.Name))}."
            );
            foreach (Degree deg in uprogram.Degrees)
            {
                Console.WriteLine(
                    $"The {deg.Name} degree contains the following courses: {String.Join(", ", deg.Courses.Select(c => c.Name))}."
                );
                foreach(Course crs in deg.Courses)
                {
                    Console.WriteLine(
                        $"The {crs.Name} course has {crs.Teachers.Length} teacher(s) and {crs.Students.Length} student(s)."
                    );
                }
            }
        }
    }
}
