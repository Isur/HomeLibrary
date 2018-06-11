using HomeLibrary.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary.Presenters
{
    public class ModifyBookPresenter
    {
        Models.Library model;
        Views.Interfaces.IModifyBook view;
        public ModifyBookPresenter(Models.Library model, IModifyBook view)
        {
            this.model = model;
            this.view = view;

            view.EditBook += model.ModifyBook;
        }

    }
}
