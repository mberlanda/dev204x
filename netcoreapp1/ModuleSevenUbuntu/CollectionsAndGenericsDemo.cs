using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ModuleSevenUbuntu
{
    public class CollectionsAndGenericsDemo
    {
        public static void CreateArrayList()
        {
            // Create a new ArrayList collection.
            ArrayList beverages = new ArrayList();

            // Create some items to add to the collection.
            Coffee coffee1 = new Coffee(4, "Arabica", "Columbia");
            Coffee coffee2 = new Coffee(3, "Arabica", "Vietnam");
            Coffee coffee3 = new Coffee(4, "Robusta", "Indonesia");

            beverages.Add(coffee1);
            beverages.Add(coffee2);
            beverages.Add(coffee3);
            Console.WriteLine($"Beverages has {beverages.Count} element(s).");

            // Retrieve items from the collection.
            // Items must be explicitly cast back to their original type.
            Coffee firstCoffee = (Coffee)beverages[0];
            Coffee secondCoffee = (Coffee)beverages[1];
            Coffee thirdCoffee = beverages[2] as Coffee;

            // Iterating Over a List Collection
            foreach(Coffee coffee in beverages)
            {
                Console.WriteLine("Bean type: {0}", coffee.Bean);
                Console.WriteLine("Country of origin: {0}", coffee.CountryOfOrigin);
                Console.WriteLine("Strength (1-5): {0}", coffee.Strength);
            }
            /*
            beverages.ToArray().ToList().ForEach(c => {
                var coffee = c as Coffee;
                Console.WriteLine("Bean type: {0}", coffee.Bean);
                Console.WriteLine("Country of origin: {0}", coffee.CountryOfOrigin);
                Console.WriteLine("Strength (1-5): {0}", coffee.Strength);
            });
            */
            // beverages.ToArray().ToList().ForEach(c => PrintCoffeeDetails((Coffee)c));
            // beverages.ToArray().ToList().ForEach(c => PrintCoffeeDetails(c as Coffee));
            // beverages.ToArray().ToList().ForEach(c => ((Coffee)c).PrintDetails());
        }

        static Action<Coffee> PrintCoffeeDetails = c => {
            Console.WriteLine($"Bean type: {c?.Bean}");
            Console.WriteLine($"Country of origin: {c?.CountryOfOrigin}");
            Console.WriteLine($"Strength (1-5): {c?.Strength}");
        };

        // static void Method() => Console.Write("pippo");
        public class Coffee
        {
            public int Strength { get; set; }
            public string Bean { get; set; }
            public string CountryOfOrigin { get; set; }

            public Coffee(int strength, string bean, string country)
            {
                this.Strength = strength;
                this.Bean = bean;
                this.CountryOfOrigin = country;
            }
            public void PrintDetails()
            {
                Console.WriteLine($"Bean type: {this?.Bean}");
                Console.WriteLine($"Country of origin: {this?.CountryOfOrigin}");
                Console.WriteLine($"Strength (1-5): {this?.Strength}");
            }
        }
        public static void CreateHashtable()
        {
            // Create a new Hashtable collection.
            Hashtable ingredients = new Hashtable();
            // Add some key/value pairs to the collection.
            ingredients.Add("Café au Lait", "Coffee, Milk");
            ingredients.Add("Café Mocha", "Coffee, Milk, Chocolate");
            ingredients.Add("Cappuccino", "Coffee, Milk, Foam");
            ingredients.Add("Irish Coffee", "Coffee, Whiskey, Cream, Sugar");
            ingredients.Add("Macchiato", "Coffee, Milk, Foam");
            OutPutHashtable(ingredients);
        }

        private static void OutPutHashtable(Hashtable ingredients)
        {
            // Check whether a key exists.
            if (ingredients.ContainsKey("Café Mocha"))
            {
                // Retrieve the value associated with a key.
                Console.WriteLine($"The ingredients of a Café Mocha are: {ingredients["Café Mocha"]}");
            }
            // Iterating Over a Dictionary Collection
            foreach (string key in ingredients.Keys)
            {
                // For each key in turn, retrieve the value associated with the key.
                Console.WriteLine($"The ingredients of a {key} are {ingredients[key]}");
            }
        }

        public static void CreateGenericList(){
            List<Employee> employees= new List<Employee>()
            {
                new Employee() { empID = 001, Name = "Tom", Department= "Sales"},
                new Employee() { empID = 024, Name = "Joan", Department= "HR"},
                new Employee() { empID = 023, Name = "Fred", Department= "Accounting" },
                new Employee() { empID = 040, Name = "Mike", Department= "Sales" },
            };
            // Find the member of the list that has an employee id of 023
            Employee match = employees.Find((Employee p) => { return p.empID == 023; });
            Console.WriteLine($"empID: {match.empID}\nName: {match.Name}\nDepartment: {match.Department}");
        }

        public class Employee
        {
            public int empID { get; set; }
            public string Name { get; set; }
            public string Department { get; set; }
        }

    }
}
