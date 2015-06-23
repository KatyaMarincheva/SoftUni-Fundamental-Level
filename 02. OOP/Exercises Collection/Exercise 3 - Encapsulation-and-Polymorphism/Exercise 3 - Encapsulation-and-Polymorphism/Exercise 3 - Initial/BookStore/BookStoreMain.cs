namespace BookStore
{
    using Engine;

    public class BookStoreMain
    {
        public static void Main()
        {
            BookStoreEngine engine = new BookStoreEngine();

            engine.Run();
        }
    }
}
