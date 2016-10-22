using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTwo
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
                string lineOutput = "";
                for (int w = 0; w < width; w++)
                {
                    lineOutput += evalPosition(h + w);
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
