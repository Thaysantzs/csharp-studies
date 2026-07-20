using System;
using Ourcompany;
using MyArray;
/*27. Implement a game of decoding a sequence of integer digits
    The game rules are:
    - Generate an array of random integer digits without duplication
    - Allow the player to provide 5 numbers each turn
    - Show * for each digit that is in a correct position
    - Show + for each digit that is out position
    - Show - for each digit that is not part of the list
    - Keep the game until the player get all five *
    Example:
    Secret: 02815
    Turn 1
    Input:  69234
    Output: --+--   
    Turn 2
    Input:  02784
    Ouput:  **-+-
    Turn 3
    Input:  02681
    Output: **-++
    Turn 4
    Input:  02851
    Output: ***++
    Turn 5
    Input:  02815
    Output: *****
    Congrats, You won!*/

public class ArrayQuestion27
{
    public static void Main(string[] args)
    {
        int[] sequence = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] sequenceGame = RandomizeOfArray(sequence);
        int turn = 1;

        while (true)
        {
            if(turn > 5)
            {
                Console.WriteLine("You failed!! try again.");
                break;
            }

            int points = 0;

            Console.WriteLine($"\nTurn {turn}");
            Console.Write("Input:  ");
            String? input = Console.ReadLine();
            Console.Write("Output: ");
            for (int i = 0; i < sequenceGame.Length; i++)
            {
                int guess = Convert.ToInt32(input?[i].ToString());
                if(Array.IndexOf(sequenceGame, guess) == -1)
                {
                    Console.Write("-");
                } else if (sequenceGame[i] == guess)
                {
                    Console.Write("*");
                    points++;
                }
                else
                {
                    Console.Write("+");
                }
            }
            if(points == sequenceGame.Length)
            {
                Console.WriteLine($"\nCongrats! You won whit {turn} turns!!");
                break;
            }
            turn++;
        }
    }

    private static int[] RandomizeOfArray(int[] sequence)
    {
        ShuffleArrays(sequence);

        int[] sequenceGame = GetFiveNumbers(sequence);

        return sequenceGame;
    }

    private static int[] GetFiveNumbers(int[] sequence)
    {
        int[] sequenceGame = new int[5];
        for (int i = 0; i < sequenceGame.Length; i++)
        {
            sequenceGame[i] = sequence[i];
        }

        return sequenceGame;
    }

    private static void ShuffleArrays(int[] sequence)
    {
        Random random = new Random();
        int aux = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            int rdn = random.Next(i, sequence.Length);
            aux = sequence[i];
            sequence[i] = sequence[rdn];
            sequence[rdn] = aux;
        }
    }
}