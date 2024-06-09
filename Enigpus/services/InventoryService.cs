using Enigpus.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigpus.services
{
    internal interface InventoryService
    {
        void AddBook(Book book);
        Book SearchBook(string title);
        List<Book> GetAllBooks();
    }
}
