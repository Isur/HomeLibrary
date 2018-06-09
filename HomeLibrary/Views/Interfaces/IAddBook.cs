using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Views.Interfaces
{
    public interface IAddBook
    {
        string Title { get; set; }
        string Publisher { get; set; }
        int Year { get; set; }
        string AuthorFirstName { get; set; }
        string AuthorLastName { get; set; }
        string AuthorFrom { get; set; }
    }
}
