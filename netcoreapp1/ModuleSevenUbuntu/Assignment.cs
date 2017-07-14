using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ModuleSevenUbuntu {

    public class Person {
        public Person(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        protected string _lastName;
        public virtual string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
     }
    public class Student:Person {

        // Create a Stack object inside the Student object, called Grades, to store test scores.
        public Student (string first, string last):base(first, last) {
            this.Grades = new Stack<double>();
        }
        public void TakeTest() {
            Console.WriteLine($"{this.FirstName} is taking the test.");
        }

        public Stack<double> Grades { get; set; }

        public override string LastName
        {
            get { return _lastName.ToUpper(); }
            set { _lastName = value; }
        }

    }

    public class Course
    {
        // Delete the Student array in your Course object that you created in Module 5.
        // Create an ArrayList to replace the array and to hold students, inside the Course object.
        // Modify your code to use the ArrayList collection as the replacement to the array.
        // In other words, when you add a Student to the Course object, you will add it to the ArrayList and not an array.

        public Course(string name)
        {
            this.Name = name;
            this.Students = new ArrayList();
        }
        public ArrayList Students;
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void ListStudents()
        {
            ArrayList studentNames = new ArrayList();
            this.Students.ToArray().ToList().ForEach(student => {
                var s = (Student)student;
                studentNames.Add($"{s.LastName} {s.FirstName}");
            });
            studentNames.Sort();
            foreach(String n in studentNames){ Console.WriteLine(n); }
        }
    }
}
