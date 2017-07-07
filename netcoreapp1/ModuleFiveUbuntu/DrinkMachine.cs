using System;

namespace ModuleFiveUbuntu
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }

        // The following statements declare private member variables
        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _make;
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        private string _model;
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public void MakeCappucino()
        {
            // Method logic goes here
            Console.WriteLine("Cappucino is made.");
        }

        public void MakeExpresso()
        {
            // Method logic goes here
        }

        // Static Members in Non-static Classes
        public static int CountDrinksMachines()
        {
            // Add method logic here.
            return 1;
        }
    }
}
