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
            var find = new List<Book>();
            
            foreach(var book in Books)
            {                
                if (book.Title.ToLower().Contains(title.ToLower()))
                {
                    find.Add(book);                    
                }
            }

            return find;
        }

        public List<Book> SearchByAuthor(string authorLastName)
        {
            var find = new List<Book>();

            foreach (var book in Books)
            {
                if (book.Author.ToStringName().ToLower().Contains(authorLastName.ToLower()))
                {
                    find.Add(book);
                }
            }

            return find;
        }

        public List<Book> SearchByYear(int year)
        {
            var find = new List<Book>();

            foreach (var book in Books)
            {
                if (book.Year == year)
                {
                    find.Add(book);
                }
            }

            return find;
        }

        public List<Book> SearchByPublisher(string publisher)
        {
            var find = new List<Book>();

            foreach (var book in Books)
            {
                if (book.Publisher.ToLower().Contains(publisher.ToLower()))
                {
                    find.Add(book);
                }
            }

            return find;
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

        public bool ModifyBook(uint id, string title, string publisher, int year, string authorFirstName, string authorLastName, string authorFrom)
        {
            try
            {
                var t = Books.Find(x => x.Id == id);
                t.Title = title;
                t.Publisher = publisher;
                t.Year = year;
                t.Author.FirstName = authorFirstName;
                t.Author.LastName = authorLastName;
                t.Author.From = authorFrom;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        #endregion

    }
}
