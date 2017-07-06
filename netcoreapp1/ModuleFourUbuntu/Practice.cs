using System;

namespace ModuleFourUbuntu
{
    public class Practice
    {
        internal struct Student
        {
            public string firstName  { get; set; }
            public string lastName  { get; set; }
            public DateTime birthday { get; set; }
        }
        internal struct Teacher
        {
            public string firstName  { get; set; }
            public string lastName  { get; set; }
            public DateTime birthday  { get; set; }
        }
        internal struct Program
        {
            public string name  { get; set; }
            public string departmentHead  { get; set; }
            public Degree[] Degrees  { get; set; }


        }
        internal struct Degree
        {
            public string name  { get; set; }
            public string category  { get; set; }
            public int creditsRequired  { get; set; }
        }

        internal struct Course
        {
            public string name  { get; set; }
            public int durationInWeeks  { get; set; }
            public int credits  { get; set; }
        }
    }
}
