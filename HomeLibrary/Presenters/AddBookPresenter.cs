using HomeLibrary.Models;
using HomeLibrary.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Presenters
{
    public class AddBookPresenter
    {
        Library model;
        IAddBook view;
        public AddBookPresenter(Library model, IAddBook view)
        {
            this.model = model;
            this.view = view;

            view.NewBook += model.AddBook;
        }
    }
}
