using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_OTC.Model
{
    class CompanyIdentity
    {
        #region Declaration
        private string nomorPerusahaan;
        private string namaPerusahaan;
        private string alamatPerusahaan;
        private string kecamatan;
        private string kota;
        private string provinsi;
        private string kodePos;
        private string emai;
        private string website;
        private string telepon;
        private string mobile;
        private string logoPerusahaan;
        #endregion

        #region Properties
        public string NomorPerusahaan
        {
            get { return nomorPerusahaan; }
            set { nomorPerusahaan = value; }
        }
        public string NamaPerusahaan
        {
            get { return namaPerusahaan; }
            set { namaPerusahaan = value; }
        }
        public string AlamatPerusahan
        {
            get { return alamatPerusahaan; }
            set { alamatPerusahaan = value; }
        }
        public string Kecamatan
        {
            get { return kecamatan; }
            set { kecamatan = value; }
        }
        public string Kota
        {
            get { return kota; }
            set { kota = value; }
        }
        public string Provinsi
        {
            get { return provinsi; }
            set { provinsi = value; }
        }
        public string KodePos
        {
            get { return kodePos; }
            set { kodePos = value; }
        }
        public string Email
        {
            get { return emai; }
            set { emai = value; }
        }
        public string Website
        {
            get { return website; }
            set { website = value; }
        }
        public string Telepon
        {
            get { return telepon; }
            set { telepon = value; }
        }
        public string Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }
        public string LogoPerusahaan
        {
            get { return logoPerusahaan; }
            set { logoPerusahaan = value; }
        }
        #endregion
    }
}
