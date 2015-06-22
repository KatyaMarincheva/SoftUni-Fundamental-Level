/* Problem 1. Square Root
Write a program that reads an integer number and calculates and prints its square root. 
 * If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
 */

using System;

internal class SquareRoot
{
    internal static void Main()
    {
        Console.Write("Please, enter an integer number: ");
        try
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException("input", "Input cannot be empty");
            }

            int number = int.Parse(input);

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number", "Sqrt for negative numbers is undefined!");
            }
            
            Console.WriteLine("The square root of {0} is {1:F2}", number, Math.Sqrt(number));
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}