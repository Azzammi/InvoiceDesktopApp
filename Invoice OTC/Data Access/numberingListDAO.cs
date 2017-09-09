using Invoice_OTC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC.Data_Access
{
    class numberingListDAO
    {
        #region Constructor

        #endregion

        #region Method

        public void LoadNumberList(string namaTabel,string namaField)
        {
            //Built SQL String
            string sql = string.Format("SELECT {0} FROM {1} order by {0} DESC", namaField, namaTabel);

            //Execute String
            int number = DataProvider.ExecuteScalar(sql);

            //Declare Item
            numberingItem result = null;

            if(number == 0)
            {
                result = new numberingItem();
                result.NumberIncrement = 1;
            }
            else
            {
                result = new numberingItem();
                result.NumberIncrement = number + 1;
            }
        }

        #endregion


        //public string GenerateNumber(string namaTabel, string namaField)
        //{
        //    //ClsKoneksi koneksi = new ClsKoneksi();          
        //    if (con_open())
        //    {
        //        string number;
        //        using (Perintah = new MySqlCommand("SELECT " + namaField + " FROM " + namaTabel + " order by " + namaField + " DESC", Koneksi))
        //        {
        //            RaDa = Perintah.ExecuteReader();
        //            RaDa.Read();
        //            if (RaDa.HasRows)
        //            {
        //                number = RaDa["" + namaField + ""].ToString();
        //                number = number.Substring(number.Length - 6, 6);
        //                int num = int.Parse(number) + 1;

        //                RaDa.Close();
        //                con_close();

        //                return num.ToString();
        //            }
        //            else
        //            {
        //                RaDa.Close();
        //                con_close();

        //                return "100001";
        //            }
        //        }
        //    }
        //    return "False";
        //}
    }

}
