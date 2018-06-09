using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeLibrary.Models.Interfaces;
namespace HomeLibrary.Models
{
    public class Library : IBookManagement, ISearch
    {
        private List<Book> books;
        public Library()
        {
            books = new List<Book>();
        }
        #region INTERFACES
        public void AddBook(string title, string publisher, int year, string authorFirstName, string authorLastName, string authorFrom)
        {
            books.Add(new Book(title, publisher, year, authorFirstName, authorLastName, authorFrom));
        }
        public void AddBook(string title, string publisher, int year, Author author)
        {
            books.Add(new Book(title, publisher, year, author));
        }
        public void DeleteBook(string title, string authorLastName)
        {
            throw new NotImplementedException();
        }
        public List<Book> SearchByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<Book> SearchByAuthor(string authorLastName)
        {
            throw new NotImplementedException();
        }

        public List<Book> SearchByYear(int year)
        {
            throw new NotImplementedException();
        }

        public List<Book> SearchByPublisher(string publisher)
        {
            throw new NotImplementedException();
        }


        #endregion

    }
}
