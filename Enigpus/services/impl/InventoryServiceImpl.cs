using Enigpus.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigpus.services.impl
{
    public class InventoryServiceImpl : InventoryService
    {
        List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            try
            {
                books.Add(book);
            }catch{ }
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book SearchBook(string title)
        {
            List<Book> books = GetAllBooks();
            Book output = null;
            foreach (Book book in books)
            {
                if (book.Title.ToLower() == title.ToLower())
                {
                    output = book;
                    break;
                }
            }

            return output;
        }
    }
}
