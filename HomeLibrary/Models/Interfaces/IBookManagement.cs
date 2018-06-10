using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models.Interfaces
{
    public interface IBookManagement
    {
        bool AddBook(string title, string publisher, int year, string authorFirstName, string authorLastName, string authorFrom);
        bool AddBook(string title, string publisher, int year, Author author);
        bool DeleteBook(uint id);
        List<Book> GetBooks();
        bool Save();
        /* TO DO
         * 
         * ADD MODIFY OPTION
         * 
         *  */ 
    }
}
