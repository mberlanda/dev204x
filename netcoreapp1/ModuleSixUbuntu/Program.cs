using System;
using System.Dynamic;

namespace ModuleSixUbuntu
{
    class Program
    {
        static void Main(string[] args)
        {
            runDemos();
            runAssignment();
        }
        static void runDemos(){
            Demo.InheritanceDemo();
            Demo.PolymorphismDemo();
            Demo.GarbageCollectorDemo();
        }
        static void runAssignment()
        {
            // Create an instance of a Person object in code
            Person pers = new Person("Martin", "Luther");
            // Create an instance of a Student object in code
            Student stud = new Student("Paulette", "Bridges");
            // Assign the Student object to the Person object
            Console.WriteLine($"Person before: {pers.FirstName} {pers.LastName} ({pers.GetType()})");
            pers = stud;
            Console.WriteLine($"Person after: {pers.FirstName} {pers.LastName} ({pers.GetType()})");

            Student castedPers = pers as Student;
            castedPers.TakeTest();

            dynamic dynamicPers = pers;
            dynamicPers.TakeTest();

            // Another example
            Student stud1 = new Student("Amos", "Walsh");
            Teacher teach1 = new Teacher("Amos", "Walsh");
            Person persStud1 = stud1 as Person;
            Person persTeach1 = teach1 as Person;

            Person[] people = { stud1, persStud1, teach1, persTeach1 };
            foreach(var p in people){
                Console.WriteLine($"{p.FirstName} is a {p.GetType()}");
            }
        }
    }
}
