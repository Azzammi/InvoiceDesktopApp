using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InvoiceOTC.Repository.API
{
    public interface IBaseFormCRUD
    {
        void BindingSource_ListChanged(object sender, ListChangedEventArgs e);
        void BindingSource_AddingNew(object sender, AddingNewEventArgs e);
    }
}
