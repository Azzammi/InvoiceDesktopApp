using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FSCollections;
using System.ComponentModel;

namespace Invoice_OTC.Model
{
    class outletGenericList<T> : FSBindingList<OUTLET>
    {
        private List<OUTLET> list;
        //private BindingList<OUTLET> bindingList;

        public outletGenericList(List<OUTLET> list)
        {
            this.list = list;
        }
        
        public List<OUTLET> List
        {
            get { return List; }    
            set { list = value; }       
        }            
        public BindingList<OUTLET> BindingLists
        {
            get { return new BindingList<OUTLET>(list); }
        }  
    }
}
