using System;

namespace ModuleSixUbuntu {

    // Create a Person base class with common attributes for a person
    public class Person {
        public Person(string first, string last)
        {
            this.FirstName = first;
            this.LastName = last;
        }
        protected string _firstName;
        public virtual string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
     }
    // Make your Student and Teacher classes inherit from the Person base class
    // Modify your Student and Teacher classes so that they inherit the common attributes from Person
    // Modify your Student and Teacher classes so they include characteristics specific to their type.
    // For example, a Teacher object might have a GradeTest() method where a student might have a TakeTest() method.
    public class Student:Person {
        public Student (string first, string last):base(first, last) {}
        public void TakeTest() {
            Console.WriteLine($"{this.FirstName} is taking the test.");
        }

        public override string FirstName
        {
            get { return _firstName.ToUpper(); }
            set { _firstName = value; }
        }
    }
    public class Teacher:Person {
        public Teacher (string first, string last):base(first, last) {}
        public override string FirstName
        {
            get { return _firstName.ToLower(); }
            set { _firstName = value; }
        }
        public void GradeTest() {}
    }



}