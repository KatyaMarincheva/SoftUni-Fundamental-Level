namespace _04.Book_Shop
{
    using System;

    public class BookShopMain
    {
        public static void Main()
        {
            Book book = new Book("Pod Igoto", "Ivan Vazov", 15.90m);
            Console.WriteLine(book);

            GoldenEditionBook goldenBook = new GoldenEditionBook("Tutun", "Dimitar Dimov", 22.90m);
            Console.WriteLine(goldenBook);
        }
    }
}
