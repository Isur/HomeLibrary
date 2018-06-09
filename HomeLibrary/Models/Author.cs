using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
                
        public string From { get; set; }

        public Author(string firstName, string lastName, string from)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.From = from;
        }

        public Author() { }
        override public string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
