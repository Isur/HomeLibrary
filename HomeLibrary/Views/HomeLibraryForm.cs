using HomeLibrary.Models;
using HomeLibrary.Presenters;
using HomeLibrary.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLibrary.Views
{
    public partial class HomeLibraryForm : Form, IViewChanger
    {
        UserControl activeControl;
        Library model;
        public HomeLibraryForm()
        {
            InitializeComponent();
            model = new Models.Library();
        }

        private void HomeLibraryForm_Load(object sender, EventArgs e)
        {
            ShowMainView();
        }


        private void centerActualView()
        {
            activeControl.Left = (this.Width - activeControl.Width) / 2;
            activeControl.Top = (this.Height - activeControl.Height) / 2;
        }
        private void showView(UserControl view)
        {
            Controls.Remove(activeControl);
            activeControl = view;
            Controls.Add(activeControl);
        }

        private void HomeLibraryForm_Resize(object sender, EventArgs e)
        {
            centerActualView();
        }

        public void ShowMainView()
        {
            var view = new MainView(this);
            var presenter = new MainPresenter(model, view);
            showView(view);
            centerActualView();
        }

        public void ShowAddBookView()
        {
            var view = new AddBook(this);
            var presenter = new AddBookPresenter(model, view);
            showView(view);
            centerActualView();
        }
    }
}
