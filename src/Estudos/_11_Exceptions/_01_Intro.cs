using System;

/*
# Exception handling is a crucial aspect of dealing with unexpected
  or exceptional situations that may happen during program execution.
# Definition
  # Exception are classes
  # The class Exception is the base class of all exceptions
  # Exceptions represent errors or exceptional conditions that occur during runtime.
  # They can be thrown by the .NET runtime, third-party libraries, or your application code.
  # When an exception occurs, it disrupts the normal flow of execution.
# Handling Exceptions:
  # Use the following keywords for exception handling:
    # try: Encloses the code that might throw an exception.
    # catch: Defines an exception handler to handle specific types of exceptions.
    # finally: Contains cleanup code that runs regardless of whether an exception occurred.
  # If no appropriate catch block exists for a specific exception,
    the program terminates with an error message.
  # Sintaxe: Base case
    try {
      // block of code
    } catch (Exception1 ex) {
      // do something
    } catch (Exception1 ex) {
      // do something
    } catch (ExceptionN ex) {
      // do something
    } finally () {
      // do cleanup code
    }
*/
namespace Execptions;

public class IntroApp
{
    public static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Numero 1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Numero 2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                decimal division = num1 / (decimal)num2;
                Console.WriteLine($"{num1} / {num2} = {division}");
            }catch(Exception ex)
            {
                Console.WriteLine($"Error => {ex.Message}");
            }
        }
    }
}