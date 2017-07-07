using System;

namespace ModuleFiveUbuntu
{
    /*
    In this assignment, you need to convert your objects for the application into class files.
    Create a class file for:
    A Student
    A Teacher
    A UProgram (C# uses Program as the name of the class that contains Main() so we must use a different class name here)
    A Degree
    A Course
    */

    public class Person
    {
        public Person(string first, string last, DateTime day)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Birthday = day;
        }
        private string _firstName;
        public string FirstName
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
        private DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
    }
    public class Student:Person {
        public Student (string first, string last, DateTime day):base(first, last, day) {}
    }
    public class Teacher:Person {
        public Teacher (string first, string last, DateTime day):base(first, last, day) {}
    }

    public class UProgram
    {
        public UProgram(string name, Degree[] degrees)
        {
            this.Name = name;
            this.Degrees = degrees;
        }
        public UProgram(string name)
        {
            this.Name = name;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private Degree[] _degrees;
        public Degree[] Degrees
        {
            get { return _degrees; }
            set { _degrees = value; }
        }
    }
    public class Degree
    {
        public Degree(string name, Course[] course)
        {
            this.Name = name;
            this.Courses = course;
        }
        public Degree(string name)
        {
            this.Name = name;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private Course[] _courses;
        public Course[] Courses
        {
            get { return _courses; }
            set { _courses = value; }
        }
    }

    public class Course
    {
        public Course(string name, Teacher[] teachers, Student[] students)
        {
            this.Name = name;
            this.Teachers = teachers;
            this.Students = students;
        }

        public Course(string name)
        {
            this.Name = name;
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private Teacher[] _teachers;
        public Teacher[] Teachers
        {
            get { return _teachers; }
            set { _teachers = value; }
        }
        private Student[] _students;
        public Student[] Students
        {
            get { return _students; }
            set { _students = value; }
        }
    }
}