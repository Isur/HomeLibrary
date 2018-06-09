using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Models.Interfaces
{
    public interface ISearch
    {
        List<Book> SearchByTitle(string title);
        List<Book> SearchByAuthor(string authorLastName);
        List<Book> SearchByYear(int year);
        List<Book> SearchByPublisher(string publisher);
    }
}
