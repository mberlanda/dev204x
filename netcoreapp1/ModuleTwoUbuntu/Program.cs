using System;
using System.Text;

namespace ModuleTwoUbuntu
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the pattern of a chess board that is 8 x 8 using X and O to represent the squares.

            Console.WriteLine("Here is my chess board:");

            //string oddLine = "XOXOXOXO";
            //string evenLine = "OXOXOXOX";


            //for (int line = 0; line  < 8; line++)
            //{
            //    if (line % 2 == 0)
            //    {
            //        Console.WriteLine(oddLine);
            //    } else
            //    {
            //        Console.WriteLine(evenLine);
            //    }

            //}

            int height = 8;
            int width = 8;

            for (int h = 0; h < height; h++)
            {
                StringBuilder lineOutput = new StringBuilder();
                for (int w = 0; w < width; w++)
                {
                    lineOutput.Append(evalPosition(h + w));
                }
                Console.WriteLine(lineOutput);
            }
            Console.WriteLine("Press any key to close the console");
            Console.ReadKey();
        }
        static string evalPosition(int x)
        {
            if (x % 2 == 0)
            {
                return "X";
            } else
            {
                return "O";
            }
        }

    }
}
