using System;
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

class RepetitionQuestion18
{
    public static void Main(string[] args)
    {
        Console.Write("Height: ");
        int height = Convert.ToInt32(Console.ReadLine());

        int spaces = height - 1;
        int stars = 1;

        for (int line = 1; line <= height; line++)
        {
            // Printing spaces
            for (int i = 1; i <= spaces; i++)
            {
                Console.Write(" ");
            }
            // First level is the stars (*)
            if (line == 1)
            {
                for (int i = 1; i <= stars; i++)
                {
                    Console.Write("*");
                }
            }
            else // Starting on second level, leafs (.)
            {
                for (int i = 1; i <= stars; i++)
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();

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