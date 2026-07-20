using System;
using Ourcompany;
/*
 *18. Read an integer number H and print a Christmas Tree with height H.
    e.g.
    Height = 7
          *
         ...
        .....
       .......
      .........
     ...........
    .............
          |
          |
*/

class ModularizationIntro3
{
    public static void Main(string[] args)
    {
        int height = Library.ReadInterge("Height", "-");
        int spaces = height - 1;
        int stars = 1;

        for (int line = 1; line <= height; line++)
        {
            // Printing spaces
            Library.RepeatChar(spaces, " ");

            // First level is the stars (*)
            if (line == 1)
            {
                Console.Write("*");
            }
            else // Starting on second level, leafs (.)
            {
                Library.RepeatChar(stars, ".");
                Console.WriteLine();
            }

            spaces--;
            stars += 2;
        }

        // Printing the truck
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j < height; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|");
        }
    }
} 