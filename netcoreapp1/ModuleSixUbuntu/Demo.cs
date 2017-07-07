using System;

namespace ModuleSixUbuntu {
    class Demo {

        internal static void InheritanceDemo()
        {
            Manager leadManager = new Manager();
            leadManager.LastName = "Daviti";
            leadManager.Login();
            leadManager.Hire();
        }
        internal static void PolymorphismDemo()
        {
            Customer customer1 = new Customer();
            ILoyaltyCardHolder customer2 = new Customer();

            // Representing an Object as an Interface Type
            Coffee coffee1 = new Coffee();
            IBeverage coffee2 = new Coffee();

            // Casting to an Interface Type
            IBeverage beverage = coffee1;

            // Casting an Interface Type to a Derived Class Type
            Coffee coffee3 = beverage as Coffee;
            Coffee coffee4 = (Coffee)beverage;

            // Coffee coffee5 = customer2 as Coffee;
            // Console.WriteLine(coffee5 is null); // True
            // System.InvalidCastException: Unable to cast object of type 'ModuleSixUbuntu.Customer' to type 'ModuleSixUbuntu.Coffee'
            // Coffee coffee6 = (Coffee)customer2;
        }
        internal static void GarbageCollectorDemo()
        {
            /*
            Calculator calculator = new Calculator();
            int x = 120;
            int y = 15;
            Console.WriteLine($"{x} / {y} = {calculator.Divide(120, 15)}");
            Console.WriteLine("Program finishing");
            */
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine("{0} / {1} = {2}", 120, 15, calculator.Divide(120, 15));
            }
        }
    }
}