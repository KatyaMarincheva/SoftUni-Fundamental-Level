namespace _03.Exception_Handling
{
    using System;

    internal class ExceptionHandlingMain
    {
        internal static void Main()
        {
            // 1st cae
            try
            {
                Person noName = new Person(string.Empty, "Goshev", 31);
                Console.WriteLine(noName);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            // 2nd case
            try
            {
                Person negativeAge = new Person("Stoyan", "Kolev", -1);
                Console.WriteLine(negativeAge);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            // 3rd case
            try
            {
                Person perfect = new Person("Katya", "Marincheva", 52);
                Console.WriteLine(perfect);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
        }
    }
}
