using System;

namespace ModuleFiveUbuntu
{
    class Demo
    {
        static public void DrinkMachineDemo()
        {
            DrinkMachine myMachine = new DrinkMachine();
            myMachine._location = "Kitchen";
            myMachine._model = "DM1000";

            Console.WriteLine(myMachine._location);
            myMachine.MakeCappucino();
        }
    }
}
