namespace _04.Book_Shop
{
    public class GoldenEditionBook : Book
    {
        private const decimal Rate = 1.3m;

        public GoldenEditionBook(string title, string author, decimal price) 
            : base(title, author, price)
        {
        }

        public override decimal Price
        {
            get
            {
                return base.Price * Rate;
            }
        }
    }
}
