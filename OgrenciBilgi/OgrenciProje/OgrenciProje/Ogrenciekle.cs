using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciProje
{
    public class Ogrenciekle
    {
        private string _ad;
        private string _soyad;
        
        
        public int id { get; set; }
        public string ad { get { return _ad; }  set { _ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); } }
        public string soyad { get { return _soyad; } set { _soyad = value.ToUpper(); } }
        public string dogumtarihi { get; set; }
        public string cinsiyet { get; set; }
        public string Sınıf { get; set; }
        public string tcNo { get; set; }
    }
}
