using System;

public class TextFileprocessing
{
    public static void Main(string[]? args)
    {
        string filePath = "_12_UnitTesting/InputFile.txt";
        StreamReader? reader = null;
        try
        {
            int number;
            int sum = 0;
            int count = 0;
            reader = new StreamReader(filePath);
            while(!reader.EndOfStream)
            {
                try
                {
                    number = Convert.ToInt32(reader.ReadLine());
                    sum += number;
                    count++;
                    Console.WriteLine($"{count}: {number}");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid Value");
                }
            }
            decimal average = (decimal) sum / count;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Avarage: {average}");
        }
        catch(Exception ex)
        {
            throw new Exception($"An Unexpected error occurred: {ex.Message}");
        }
        finally
        {
            if(reader != null)
            {
                reader.Close();
            }
        }
    }
}