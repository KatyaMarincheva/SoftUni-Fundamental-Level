/* Problem 2. Enter Numbers
Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 * If an invalid number or non-number text is entered, the method should throw an exception. 
 * Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
 * If the user enters an invalid number, let the user to enter again.
 */

using System;
using System.Linq;

public class EnterNumbers
{
    public static void Main()
    {
        int[] numbers = new int[10];

        for (int i = 0; i < 10; i++)
        {
            int maxArrayElement = numbers.Max();
            int min = Math.Max(2, maxArrayElement + 1);
            int max = 100 - 10 + i;
            Console.Write("Enter a number: ");
            numbers[i] = ReadNumber(min, max);
        }

        Console.WriteLine("\nYou entered the following 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Number {0}: {1}", i + 1, numbers[i]);
        }
    }

    public static int ReadNumber(int start, int end)
    {
        string input = Console.ReadLine();

        try
        {
            int num = int.Parse(input);

            if (num < start || num > end)
            {
                throw new ArgumentOutOfRangeException("input", string.Format("Number should be between {0} and {1}.", start, end));
            }

            return num;
        }
        catch (Exception)
        {
            Console.Write("Number should be in the range [{0} ... {1}]. Please re-enter: ", start, end);
            return ReadNumber(start, end);
        }
    }
}
