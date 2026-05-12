using System;

/*
# Sintaxe: Multiple exceptions
    try {
        // block of code
    } catch (ExceptionType1 ex1) {
        // Ex 1
    } catch (ExceptionType2 ex3) {
        // Ex 2
    } catch (...) {
        // Ex N
    }
*/

namespace Execptions;

public class MultipleApp
{
    public static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.Write("Numero 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Numero 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                decimal division = num1 / (decimal)num2;
                Console.WriteLine($"{num1} / {num2} = {division}");
            }catch(FormatException)
            {
                Console.WriteLine($"Value is invalid!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The value is too big!");
            }catch(Exception ex)
            {
                Console.WriteLine("Unexpected error");
                Console.WriteLine($"Type Error: {ex.GetType()}");
                Console.WriteLine($"Message: {ex.Message}");
            }
        }
    }
}