namespace BookStore.Books
{
    using Interfaces;

    public class Magazine : IBook
    {
        public Magazine(string title, decimal price)
        {
            this.Price = price;
            this.Title = title;
        }

        public string Title { get; set; }

        public decimal Price { get; set; }
    }
}
