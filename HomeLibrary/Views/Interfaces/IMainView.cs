using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeLibrary.Models;
namespace HomeLibrary.Views.Interfaces
{
    public interface IMainView
    {
        List<Book> Books { get; set; }
        event Func<uint, bool> DeleteBook;
        event Func<string, List<Book>> SearchByTitle;
        event Func<string, List<Book>> SearchByAuthor;
        event Func<string, List<Book>> SearchByPublisher;
        event Func<int, List<Book>> SearchByYear;
        event Func<List<Book>> GetBooks;
        event Func<bool> Save;
    }
}
