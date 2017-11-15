using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using Invoice_OTC.Data_Access;

namespace Invoice_OTC.Model
{
    [Serializable]
    public class RotiToChooseItem : FSBindingItem
    {
        #region Declarations

        //Member Variables
        private string itemCode;
        private string itemName;
        private string itemSort;
        private string brand;
        private string jenis;
        private string category;
        private string subCategory;
        private Nullable<decimal> price;
        private bool stat;
        #endregion

        #region Constructor

        public RotiToChooseItem()
        {

        }

        #endregion

        #region Properties

        public string ItemCode
        {
            get { return itemCode; }
            set { itemCode = value; }
        }

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public string ItemSort
        {
            get { return itemSort; }
            set { itemSort = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Jenis
        {
            get { return jenis; }
            set { jenis = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public string SubCategory
        {
            get { return subCategory; }
            set { subCategory = value; }
        }
        public Nullable<decimal> Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Stat
        {
            get { return stat; }
            set { stat = value; }
        }
        #endregion

        #region Method
        internal void CreateDatabaseRecord()
        {
            RotiToChooseItemDAO dao = new RotiToChooseItemDAO();
            dao.CreateDatabaseRecord(this);
        }
        internal void UpdateDatabaseRecord()
        {
            RotiToChooseItemDAO dao = new RotiToChooseItemDAO();
            dao.UpdateDatabaseRecord(this);
        }
        internal void DeleteDatabaseRecord()
        {
            RotiToChooseItemDAO dao = new RotiToChooseItemDAO();
            dao.DeleteDatabaseRecord(this.ItemCode);
        }
        #endregion
    }
}
