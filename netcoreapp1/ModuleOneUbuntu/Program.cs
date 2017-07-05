using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleOneUbuntu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student Information
            string firstName;
            string lastName;
            DateTime birthdate;
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            string zipPostal;
            string country;

            //Teacher Information
            //string firstName;
            //string lastName;
            //DateTime birthdate;
            //string addressLine1;
            //string addressLine2;
            //string city;
            //string stateProvince;
            //string zipPostal;
            //string country;

            //UProgram Information
            //string programName;
            //string departmentHead;
            //string degrees;

            //Degree Information
            //string degreeName;
            //int creditsRequired;

            //Course Information
            //string courseName;
            //int credits;
            //int durationInWeeks;
            //string teacher;

            // Student Information Example
            firstName = "Tom";
            lastName = "Sawyer";
            birthdate = new DateTime(1980, 01, 05);
            addressLine1 = "Blackthorne Road";
            addressLine2 = "";
            city = "Poyle";
            stateProvince = "Berkshire";
            zipPostal = "SL3 0DA";
            country = "United Kingdom";

            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine("Birthdate: {0:D}", birthdate);
            Console.WriteLine("Address: {0}", string.Join("", new string[] { addressLine1, addressLine2 }));
            Console.WriteLine("{0} {1}", zipPostal, string.Join(", ", new string[] { city, stateProvince, country }));
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }
    }
}
