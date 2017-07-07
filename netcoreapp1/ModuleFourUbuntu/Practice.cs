using System;

namespace ModuleFourUbuntu
{
    public class Practice
    {
        internal struct Student
        {
            public string FirstName  { get; set; }
            public string LastName  { get; set; }
            public DateTime Birthday { get; set; }
        }
        internal struct Teacher
        {
            public string FirstName  { get; set; }
            public string LastName  { get; set; }
            public DateTime Birthday  { get; set; }
        }
        internal struct Program
        {
            public string Name  { get; set; }
            public string DepartmentHead  { get; set; }
            public Degree[] Degrees  { get; set; }

        }
        internal struct Degree
        {
            public string Name  { get; set; }
            public string Category  { get; set; }
            public int CreditsRequired  { get; set; }
        }

        internal struct Course
        {
            public string Name  { get; set; }
            public int DurationInWeeks  { get; set; }
            public int Credits  { get; set; }
        }
    }
}
