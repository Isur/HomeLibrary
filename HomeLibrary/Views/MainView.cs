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
using HomeLibrary.Views.Interfaces;
using System.Text.RegularExpressions;

namespace HomeLibrary.Views
{
    public partial class MainView : UserControl, Interfaces.IMainView
    {
        private IViewChanger viewChanger;
        private List<Book> books; 
        public MainView(IViewChanger viewChanger)
        {
            InitializeComponent();
            books = new List<Book>();
            this.viewChanger = viewChanger;
            
        }

        public List<Book> Books
        {
            get
            {
                return this.books;
            }

            set
            {
                this.books.Clear();
                foreach(var item in value)
                {
                    this.books.Add(item);
                }
            }
        }

        public event Func<uint, bool> DeleteBook;
        public event Func<string, List<Book>> SearchByAuthor;
        public event Func<string, List<Book>> SearchByPublisher;
        public event Func<string, List<Book>> SearchByTitle;
        public event Func<int, List<Book>> SearchByYear;
        public event Func<List<Book>> GetBooks;
        public event Func<bool> Save;

        private void MainView_Load(object sender, EventArgs e)
        {
            Books = GetBooks();
            foreach(var book in Books)
            {
                string[] bookInfo = { book.Id.ToString(), book.Title, book.Year.ToString(), book.Author.ToString(), book.Publisher };
                ListViewItem bookItem = new ListViewItem(bookInfo);
                listViewBooks.Items.Add(bookItem);
            }
            Save();

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            viewChanger.ShowAddBookView();

        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in listViewBooks.SelectedItems)
            {
                if (DeleteBook(uint.Parse(x.Text)))
                    viewChanger.ShowMainView();
            }
        }

        private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
