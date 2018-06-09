using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Publisher { get; set; }
        public Author Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string publisher, int year, string authorFirstName, string authorLastName, string authorFrom)
        {
            this.Title = title;
            this.Publisher = publisher;
            this.Year = year;
            this.Author = new Author(authorFirstName, authorLastName, authorFrom);
        }

        public Book(string title, string publisher, int year, Author author)
        {
            this.Title = title;
            this.Publisher = publisher;
            this.Year = year;
            this.Author = author;
        }
        
    }
}
