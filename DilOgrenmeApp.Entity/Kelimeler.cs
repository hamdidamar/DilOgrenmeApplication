using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DilOgrenmeApp.Entity
{
   public class Kelimeler
    {
        public int Id { get; set; }
        public string ingilizce { get; set; }
        public string turkce { get; set; }
        public string icumle { get; set; }
        public string tcumle { get; set; }
        public string sozcukturu { get; set; }
        public string fotoyolu { get; set; }
        public string kategori { get; set; }
        public string asamaNo { get; set; }
        public string sormaTarihi { get; set; }
        public string bugunTarihi { get; set; }
        public int istatistlikAy { get; set; }

        
    }
}
