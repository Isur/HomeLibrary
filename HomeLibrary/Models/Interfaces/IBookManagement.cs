using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models.Interfaces
{
    public interface IBookManagement
    {
        void AddBook(string title, string publisher, int year, string authorFirstName, string authorLastName, string authorFrom);
        void AddBook(string title, string publisher, int year, Author author);
        void DeleteBook(string title, string authorLastName);
        /* TO DO
         * 
         * ADD MODIFY OPTION
         * 
         *  */ 
    }
}
