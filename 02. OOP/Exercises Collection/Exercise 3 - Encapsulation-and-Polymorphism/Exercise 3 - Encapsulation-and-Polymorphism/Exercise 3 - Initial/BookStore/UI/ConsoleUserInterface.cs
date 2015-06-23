namespace BookStore.UI
{
    using System;

    public class ConsoleUserInterface
    {
        string ReadLine()
        {
            return Console.ReadLine();
        }

        void WriteLine(string message, params string[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}
