using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_XML
{
    internal class Book
    {
        public string Title {  get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book()
        {
            
        }
        public Book(string Title,string Author,double Price)
        {
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"Title: {Title}; Author: {Author}; Price: {Price}";
        }
    }
}
