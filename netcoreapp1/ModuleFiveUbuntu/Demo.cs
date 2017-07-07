using System;

namespace ModuleFiveUbuntu
{
    class Demo
    {
        static public void DrinksMachineDemo()
        {
            DrinksMachine myMachine = new DrinksMachine("Kitchen", "Brand", "DM1000");
            // myMachine.Location = "Kitchen";
            // myMachine.Model = "DM1000";

            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
            myMachine.MakeCappucino();

            // Access Static Members
            int drinksMachineCount = DrinksMachine.CountDrinksMachines();
        }

        static public void ConversionsDemo()
        {
            double weight = 80;
            Console.WriteLine($"{weight} Kilos are {Conversions.KilosToPounds(weight)} Pounds.");
            Console.WriteLine($"{weight} Pounds are {Conversions.PoundsToKilos(weight)} Kilos.");
            Console.WriteLine(Math.Pow(2, 8));
        }

        static public void AnonymousDemo()
        {
            #region Anon Class
            /*
            var anAnonymousObject = new { Name = "Tom", Age = 65 };
            Console.WriteLine($"Name: {anAnonymousObject.Name} Age: {anAnonymousObject.Age}.");
            var secondAnonymousObject = new { Name = "Hal", Age = 46 };
            secondAnonymousObject = anAnonymousObject;
            */

            var anon = new { Name = "Gerry", Age = 29 };
            Console.WriteLine(anon.Name + anon.Age);

            #endregion
        }
    }
}
