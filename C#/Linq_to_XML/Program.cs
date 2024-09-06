namespace Linq_to_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
           {
               new Book("Java","John Doe",150),
               new Book("Python","John Doe",200),
               new Book("DotNet","Mark",250),
               new Book("Go","Jack",300)
           };
            string path = "C:\\Users\\Administrator\\Desktop\\24NAG2219_U08\\bookstore.xml";
            BookStore store = new BookStore();
            //store.create_XML_file(books,path);
            store.get_all_books(path);
            store.get_book_titles(path);
            store.get_avg_price(path);
        }
    }
}
