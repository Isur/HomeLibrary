using HomeLibrary.Models;
using HomeLibrary.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Presenters
{
    public class MainPresenter
    {
        Library model;
        IMainView view;
        public MainPresenter(Library model, IMainView view)
        {
            this.model = model;
            this.view = view;

            view.DeleteBook += model.DeleteBook;
            view.SearchByAuthor += model.SearchByAuthor;
            view.SearchByPublisher += model.SearchByPublisher;
            view.SearchByTitle += model.SearchByTitle;
            view.SearchByYear += model.SearchByYear;
            view.GetBooks += model.GetBooks;
            view.Save += model.Save;
        }
    }
}
