using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeLibrary.Views.Interfaces;

namespace HomeLibrary.Views
{
    public partial class AddBook : UserControl, Interfaces.IAddBook
    {
        IViewChanger viewChanger;
        public AddBook(IViewChanger viewChanger)
        {
            InitializeComponent();
            this.viewChanger = viewChanger;
        }

        public string AuthorFirstName
        {
            get
            {
                return textBoxAuthorFirstName.Text;
            }

            set
            {
                textBoxAuthorFirstName.Text = value;
            }
        }

        public string AuthorFrom
        {
            get
            {
                return textBoxAuthorFrom.Text;
            }

            set
            {
                textBoxAuthorFrom.Text = value;
            }
        }

        public string AuthorLastName
        {
            get
            {
                return textBoxAuthorLastName.Text;
            }

            set
            {
                textBoxAuthorLastName.Text = value;
            }
        }

        public string Publisher
        {
            get
            {
                return textBoxPublisher.Text;
            }

            set
            {
                textBoxPublisher.Text = value;
            }
        }

        public string Title
        {
            get
            {
                return textBoxTitle.Text;
            }

            set
            {
                textBoxTitle.Text = value;
            }
        }

        public int Year
        {
            get
            {
                return int.Parse(numericUpDownYear.Value.ToString());
            }

            set
            {
                numericUpDownYear.Value = value;
            }
        }
        public event Func<string, string, int, string, string, string, bool> NewBook;

        private void AddBook_Load(object sender, EventArgs e)
        {

            numericUpDownYear.Maximum = DateTime.Now.Year;
            numericUpDownYear.Minimum = -2500;
            /* In Ancient Egypt, papyrus was used as a medium for writing surfaces, 
             * maybe as early as from First Dynasty, 
             * but first evidence is from the account books of 
             * King Neferirkare Kakai of the Fifth Dynasty (about 2400 BC)*/
            numericUpDownYear.Value = 2000;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            viewChanger.ShowMainView();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                if (NewBook(Title, Publisher, Year, AuthorFirstName, AuthorLastName, AuthorFrom))
                    viewChanger.ShowMainView();
            }
        }
        private bool validation()
        {
            if(titleValidation() & publisherValidation() & authorFirstNameValidation() & authorLastNameValidation() & authorFromValidation() & yearValidation())
            {
                return true;
            }
            return false;
        }
        private bool titleValidation()
        {
            if (Title.Equals(string.Empty))
            {
                textBoxTitle.BackColor = Color.Red;
                return false;
            }
            else
            {
                textBoxTitle.BackColor = Color.White;
                return true;
            }
        }
        private bool publisherValidation()
        {
            if (Publisher.Equals(string.Empty))
            {
                textBoxPublisher.BackColor = Color.Red;
                return false;
            }
            else
            {
                textBoxPublisher.BackColor = Color.White;
                return true;
            }
        }
        private bool authorFirstNameValidation()
        {
            if (AuthorFirstName.Equals(string.Empty))
            {
                textBoxAuthorFirstName.BackColor = Color.Red;
                return false;
            }
            else
            {
                textBoxAuthorFirstName.BackColor = Color.White;
                return true;
            }
        }
        private bool authorLastNameValidation()
        {
            if (AuthorLastName.Equals(string.Empty))
            {
                textBoxAuthorLastName.BackColor = Color.Red;
                return false;
            }
            else
            {
                textBoxAuthorLastName.BackColor = Color.White;
                return true;
            }
        }
        private bool authorFromValidation()
        {
            if (AuthorFrom.Equals(string.Empty))
            {
                textBoxAuthorFrom.BackColor = Color.Red;
                return false;
            }
            else
            {
                textBoxAuthorFrom.BackColor = Color.White;
                return true;
            }
        }
        private bool yearValidation()
        {
            Console.WriteLine(numericUpDownYear.Value.ToString());
            if (numericUpDownYear.Value.ToString().Equals(string.Empty))
            {
                numericUpDownYear.BackColor = Color.Red;
                return false;
            }
            else
            {
                numericUpDownYear.BackColor = Color.White;
                return true;
            }
        }
    }
}
