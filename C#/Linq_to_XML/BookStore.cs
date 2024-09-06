using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_to_XML
{
    internal class BookStore
    {
        public void create_XML_file(List<Book> books,string path)
        {
            XDocument bookstore = new XDocument(new XDeclaration("1.0","utf-8","yes"),
                new XElement("BookStore",
                    books.Select(book => new XElement("Book",
                       new XElement("Title",book.Title),
                       new XElement("Author", book.Author),
                       new XElement("Price", book.Price)
                    ))
                ));

            bookstore.Save(path);
            
        }
        public void get_all_books(string path)
        {
            XDocument bookstore = XDocument.Load(path);
            var books = bookstore.Descendants("Book").Select(x=>new Book(x.Element("Title").Value,x.Element("Author").Value,Convert.ToInt32(x.Element("Price").Value))).ToList();
            Console.WriteLine("Book Store:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void get_book_titles(string path)
        {
            XDocument bookstore = XDocument.Load(path);
            var books = bookstore.Descendants("Book").Where(x=> x.Element("Author").Value == "John Doe").ToList();
            Console.WriteLine("Book Titles with Author John Doe");
            foreach (var book in books)
            {
                Console.WriteLine(book.Element("Title").Value);
            }
        }
        public void get_avg_price(string path)
        {
            XDocument bookstore = XDocument.Load(path);
            var avg = bookstore.Descendants("Book").Select(x => Convert.ToInt32(x.Element("Price").Value)).Average();
            Console.WriteLine($"Average price: {avg}");
        }
    }
}
