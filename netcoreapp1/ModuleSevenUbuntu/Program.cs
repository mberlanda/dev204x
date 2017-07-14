using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ModuleSevenUbuntu
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunDemos();
            RunAssignment();
        }

        static void RunDemos()
        {
            CollectionsAndGenericsDemo.CreateArrayList();
            CollectionsAndGenericsDemo.CreateHashtable();
            CollectionsAndGenericsDemo.CreateGenericList();
        }
        static void RunAssignment()
        {
            // Instantiate three Student objects.
            Student student1 = new Student("Hallr", "Waramunt");
            Student student2 = new Student("Paulinus", "Meine");
            Student student3 = new Student("Benjamín", "Fintan");
            // Add 5 grades to the the Stack in the each Student object
            List<int> grades = new List<int>{ 1, 2, 3, 4, 5 };
            grades.ForEach(g => {
                student1.Grades.Push(g * 2);
                student2.Grades.Push(g * 2.5);
                student3.Grades.Push(g * 3);
            });
            // Add the three Student objects to the Students ArrayList inside the Course object.
            Course course1 = new Course("Programming with C#");
            course1.Students.Add(student1);
            course1.Students.Add(student2);
            course1.Students.Add(student3);
            // Using a foreach loop, iterate over the Students in the ArrayList and output their
            // first and last names to the console window.
            /*
            foreach(Student s in course1.Students)
            {
                Console.WriteLine($"{s.FirstName} {s.LastName}");
            }
            */
            // Create a method inside the Course object called ListStudents() that contains the foreach loop.
            // Cast the object from the ArrayList to Student, inside the foreach loop, before printing out the name information.
            course1.ListStudents();
            // To simulate changing a grade for a student, remove the last entered grade and replace it with a new one.
            int gradesBefore = student1.Grades.Count;
            int lastEntered = (int)student1.Grades.Pop();
            Console.WriteLine($"Grades for student1 used to be {gradesBefore}. Removing {lastEntered}...");
            student1.Grades.Push(100);
            Console.WriteLine($"After adding 100, grades for student1 are {String.Join(", ", student1.Grades.ToArray())}");
            // Bonus challenge:  Ensure you have added at least 5 grades to the stack.
            // Replace the third grade in the stack without losing the two grades above it.
            var oldGrades = student1.Grades.ToArray().ToList();
            oldGrades[2] = 5000;
            oldGrades.Reverse();
            student1.Grades = new Stack<double>(oldGrades);
            Console.WriteLine(String.Join(", ", student1.Grades.ToArray()));

            // Iterate over the student collection and output the first and last name along with each of the 5 grades for that student.
            foreach(Student s  in course1.Students)
            {
                Console.WriteLine($"{s.LastName} {s.FirstName}'s grades: {String.Join(", ", s.Grades.ToArray())}");
            }
        }
    }
}
