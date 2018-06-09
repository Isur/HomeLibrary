using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeLibrary.Models;

namespace HomeLibrary.Views
{
    public partial class MainView : UserControl, Interfaces.IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public List<Book> Books
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event Func<string, string, bool> DeleteBook;
        public event Func<string, List<Book>> SearchByAuthor;
        public event Func<string, List<Book>> SearchByPublisher;
        public event Func<string, List<Book>> SearchByTitle;
        public event Func<int, List<Book>> SearchByYear;
    }
}
