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
        string sorted;
        public MainView(IViewChanger viewChanger)
        {
            InitializeComponent();
            books = new List<Book>();
            this.viewChanger = viewChanger;
            listViewBooks.ColumnClick += sort;

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
            if (listViewBooks.SelectedItems.Count < 1)
            {
                MessageBox.Show("Wybierz co chcesz usunąć.");
                return;
            }
            DialogResult result = MessageBox.Show(string.Format("Napewno chcesz usunąć wybrane książki?"), "Napewno?", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;
            foreach (ListViewItem x in listViewBooks.SelectedItems)
            {
                if (DeleteBook(uint.Parse(x.Text)))
                    viewChanger.ShowMainView();
            }
        }

        private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            search();
            showBooks();           
        }
        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
            showBooks();
        }
        private bool validation(string s)
        {
            int i;
            if(int.TryParse(s, out i))
            {
                return true;
            }
            return false;
        }

        private void search()
        {
            switch (comboBoxSearch.SelectedIndex)
            {
                case 0:
                    Books = SearchByAuthor(textBoxSearchBar.Text);
                    break;
                case 1:
                    Books = SearchByTitle(textBoxSearchBar.Text);
                    break;
                case 2:
                    if (!validation(textBoxSearchBar.Text))
                    { Books = GetBooks(); break; }
                    Books = SearchByYear(int.Parse(textBoxSearchBar.Text));
                    break;
                case 3:
                    Books = SearchByPublisher(textBoxSearchBar.Text);
                    break;
            }
        }

        private void showBooks()
        {
            listViewBooks.Items.Clear();
            foreach (var book in books)
            {
                string[] bookInfo = { book.Id.ToString(), book.Title, book.Year.ToString(), book.Author.ToString(), book.Publisher };
                ListViewItem bookItem = new ListViewItem(bookInfo);
                listViewBooks.Items.Add(bookItem);
            }
        }

        private void sort(object sender, ColumnClickEventArgs e)
        {
            int i = e.Column;
            switch (i) {
                case 0:
                    if (sorted == "ascId")
                    {
                        Books = books.OrderByDescending(x => x.Id).ToList();
                        sorted = "descId";
                    }
                    else
                    {
                        Books = books.OrderBy(x => x.Id).ToList();
                        sorted = "ascId";
                    }
                    break;
                case 1:
                    if (sorted == "ascTitle")
                    {
                        Books = books.OrderByDescending(x => x.Title).ToList();
                        sorted = "descTitle";
                    }
                    else
                    {
                        Books = books.OrderBy(x => x.Title).ToList();
                        sorted = "ascTitle";
                    }
                    break;
                case 2:
                    if (sorted == "ascYear")
                    {
                        Books = books.OrderByDescending(x => x.Year).ToList();
                        sorted = "descYear";
                    }
                    else
                    {
                        Books = books.OrderBy(x => x.Year).ToList();
                        sorted = "ascYear";
                    }
                    break;
                case 3:
                    if (sorted == "ascAuthor")
                    {
                        Books = books.OrderByDescending(x => x.Author.LastName).ToList();
                        sorted = "descAuthor";
                    }
                    else
                    {
                        Books = books.OrderBy(x => x.Author.LastName).ToList();
                        sorted = "ascAuthor";
                    }
                    break;
                case 4:
                    if (sorted == "ascPublisher")
                    {
                        Books = books.OrderByDescending(x => x.Publisher).ToList();
                        sorted = "descPublisher";
                    }
                    else
                    {
                        Books = books.OrderBy(x => x.Publisher).ToList();
                        sorted = "ascPublisher";
                    }
                    break;
            }

            showBooks();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if(listViewBooks.SelectedItems.Count == 1)
            {
                uint? id = null;
                foreach(  ListViewItem x in listViewBooks.SelectedItems)
                {
                    id = uint.Parse(x.Text);
                }
                if (id != null)
                    viewChanger.ShowModifyView(books.Find(x=>x.Id == id));
                else
                    MessageBox.Show("Wybierz jedna ksiazke do edycji.");
            }else MessageBox.Show("Wybierz jedna ksiazke do edycji.");
        }
    }

    
}
