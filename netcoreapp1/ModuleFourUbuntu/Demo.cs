using System;

namespace ModuleFourUbuntu
{
    public class Demo
    {

        internal static void ArrayDemo()
        {
            #region Array demo
                // create an integer array of size 10
                int[] intArray = new int[10];
                intArray[0] = 10;
                // create an integer array of size 5
                int[] newArray = {1, 2, 3, 4, 5};
                for (int counter = 0; counter < newArray.Length; counter++)
                {
                    Console.WriteLine(newArray[counter]);
                }
                // create two dimensional array and iterate over it
                int[,] twoDArray = { {3, 2}, {4, 5}, {5, 6} };
                for (int _x = 0; _x < twoDArray.GetLength(0); _x++)
                {
                    for (int _y = 0; _y < twoDArray.GetLength(1); _y++)
                    {
                        int value = twoDArray[_x, _y];
                        Console.WriteLine(value);
                    }
                }
            #endregion
        }
        // Enumerator declaration must be outside methods
        enum Days { Sunday=1, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        internal static void EnumDemo()
        {
            #region Enum demo
                int x = (int)Days.Sunday;
                int y = (int)Days.Friday;
                Console.WriteLine("Sun = {0}", x);
                Console.WriteLine("Fri = {0}", y);
            #endregion
        }

        internal static void StructDemo(){
            #region Struct demo
                Coffee coffee1 = new Coffee();
                coffee1.Name = "Fourth Coffee Quencher";
                coffee1.CountryOfOrigin = "Indonesia";
                coffee1.Strength = 3;
                coffee1.grind = "fine";

                Console.WriteLine("Name: {0}", coffee1.Name);
                Console.WriteLine("Country of Origin: {0}", coffee1.CountryOfOrigin);
                Console.WriteLine("Strenght: {0}", coffee1.Strength);
                Console.WriteLine("This grind is: {0}", coffee1.grind);
            #endregion
        }

        struct Coffee
        {
            public string grind;
            public string Name { get; set; }
            public string Bean { get; set; }
            public string CountryOfOrigin { get; set; }
            public int Strength { get; set; }
        }
    }
}
