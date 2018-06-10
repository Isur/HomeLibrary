using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models
{
    public class Book
    {
        private static uint counter = 0;
        public uint Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public Author Author { get; set; }
        public int Year { get; set; }

        public Book(string title, string publisher, int year, string authorFirstName, string authorLastName, string authorFrom)
        {
            counter++;
            this.Id = counter;
            this.Title = title;
            this.Publisher = publisher;
            this.Year = year;
            this.Author = new Author(authorFirstName, authorLastName, authorFrom);
            Console.WriteLine(Id);
        }

        public Book(string title, string publisher, int year, Author author)
        {
            counter++;
            this.Id = counter;
            this.Title = title;
            this.Publisher = publisher;
            this.Year = year;
            this.Author = author;
        }
        public Book()
        {

        }
        public uint getCounter()
        {
            return counter;
        }
        public void setCounter(uint c)
        {
            counter = c;
        }
    }
}
