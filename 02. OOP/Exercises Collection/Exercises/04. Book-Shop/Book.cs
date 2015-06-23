namespace _04.Book_Shop
{
    using System;
    using System.Text;

    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("title", "Title cannot be null.");
                }

                this.title = value;
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }

            protected set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("author", "Author cannot be null.");
                }

                this.author = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "Price cannot be negative.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price: {0:F2}", this.Price);

            return output.ToString();
        }
    }
}
