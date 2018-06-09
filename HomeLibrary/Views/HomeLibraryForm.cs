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
    public partial class HomeLibraryForm : Form
    {
        UserControl activeControl;
        public HomeLibraryForm()
        {
            InitializeComponent();
            
        }

        private void HomeLibraryForm_Load(object sender, EventArgs e)
        {
            showMainView();
        }

        private void showMainView()
        {
            var view = new MainView();
            showView(view);
            centerActualView();
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
    }
}
