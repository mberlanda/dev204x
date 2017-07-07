using System;

namespace ModuleSixUbuntu {

    class Manager : Employee {
        //private char payRateIndicator;
        //private Employee[] emps;
        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public override void Hire(){
            Console.WriteLine("Hire someone");
        }
        public override void Login() {
            Console.WriteLine("Manager login");
        }
    }
    abstract class Employee {
        private string empNumber;
        private string firstName;
        private string lastName;
        private string address;
        public string EmpNumber
        {
            get { return empNumber; }
            set { empNumber = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public virtual void Login() {
            Console.WriteLine("Employee login");
        }
        public virtual void LogOff() {}
        // 'Manager' does not implement inherited abstract member 'Employee.EatLunch()'
        // public abstract void EatLunch();
        public abstract void Hire();
    }

}