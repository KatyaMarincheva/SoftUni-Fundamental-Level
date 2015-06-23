namespace BookStore.Engine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Books;

    public class BookStoreEngine
    {
        private readonly List<Book> books;
        private decimal revenue;

        public BookStoreEngine()
        {
            this.IsRunning = true;
            this.books = new List<Book>();
            this.revenue = 0;
        }

        public bool IsRunning { get; private set; }

        public void Run()
        {
            while (this.IsRunning)
            {
                string command = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(command))
                {
                    continue;
                }

                string[] commandArgs = command.Split();

                string commandResult = this.ExecuteCommand(commandArgs);

                Console.WriteLine(commandResult);
            }

            Console.WriteLine("Total revenue: {0:F2}", this.revenue);
        }

        private string ExecuteCommand(string[] commandArgs)
        {
            switch (commandArgs[0])
            {
                case "add":
                    return this.ExecuteAddBookCommand(commandArgs);
                case "sell":
                case "remove":
                    return this.ExecuteRemoveSellBookCommand(commandArgs);
                case "stop":
                    this.IsRunning = false;
                    return "Goodbye!";
                default:
                    return "Unknown command";
            }
        }

        private string ExecuteRemoveSellBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];

            Book bookToSellOrRemove = this.books.FirstOrDefault(book => book.Title == title);

            if (bookToSellOrRemove == null)
            {
                return "Book does not exist";
            }

            this.books.Remove(bookToSellOrRemove);

            if (commandArgs[0] == "sell")
            {
                this.revenue += bookToSellOrRemove.Price;
                return "Book sold";
            }

            return "Book removed";
        }

        private string ExecuteAddBookCommand(string[] commandArgs)
        {
            string title = commandArgs[1];
            string author = commandArgs[2];
            decimal price = decimal.Parse(commandArgs[3]);

            this.books.Add(new Book(title, author, price));

            return "Book added";
        }
    }
}
