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
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
            BooksToXML.Deserialize(this);
            Books[0].setCounter(Books.Last<Book>().Id);
        }
        #region INTERFACES
        public bool AddBook(string title, string publisher, int year, string authorFirstName, string authorLastName, string authorFrom)
        {
            Books.Add(new Book(title, publisher, year, authorFirstName, authorLastName, authorFrom));
            return true;
        }
        public bool AddBook(string title, string publisher, int year, Author author)
        {
            Books.Add(new Book(title, publisher, year, author));
            return true;
        }
        public bool DeleteBook(uint id)
        {
            var t = Books.Find(x => x.Id == id);
            Books.Remove(t);
            return true;
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

        public List<Book> GetBooks()
        {
            return Books;
        }

        public bool Save()
        {
            BooksToXML.Serialize(this);
            return true;
        }


        #endregion

    }
}
