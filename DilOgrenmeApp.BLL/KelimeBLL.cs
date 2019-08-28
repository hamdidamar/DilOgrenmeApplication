using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DilOgrenmeApp.DAL;
using DilOgrenmeApp.Entity;


namespace DilOgrenmeApp.BLL
{
   public class KelimeBLL
    {
        KelimeHavuzuDAL _kelimeHavuzu;
        public KelimeBLL()
        {
            _kelimeHavuzu = new KelimeHavuzuDAL();

        }
        public DataTable GetAllItems(Kelimeler _kelime)
        {
            return _kelimeHavuzu.GetAllItems(_kelime);
        }
        public List<Kelimeler> GetRandItem(Kelimeler _kelime)
        {
            return _kelimeHavuzu.GetRandItem(_kelime);
        }
        public  void tarihGuncelle(Kelimeler _kelime)
        {
           _kelimeHavuzu.TarihGuncelle(_kelime);
        }
        public DataTable GetOgrendigimKelimeler(Kelimeler _kelime)
        {
           return _kelimeHavuzu.GetOgrendigimKelimeler(_kelime);
        }
        public DataTable GetOgrenilecekKelimeler(Kelimeler _kelime)
        {
            return _kelimeHavuzu.GetOgrenilecekKelimeler(_kelime);
        }
        public DataTable AylikIstatistikGetir()
        {
            return _kelimeHavuzu.AylikIstatistlikGetir();
        }
        public DataTable YillikIstatistlikGetir(int yil)
        {
            return _kelimeHavuzu.YillikIstatistlikGetir(yil);
        }
        public List<Kelimeler> GetOgrenilecekItem(Kelimeler _kelime)
        {
            return _kelimeHavuzu.GetOgrenilecekItem(_kelime);
        }
        public void AsamaNoArttir(Kelimeler _kelime)
        {
             _kelimeHavuzu.AsamaNoArttir(_kelime);
        }
        public void AsamaNoAzalt(Kelimeler _kelime)
        {
            _kelimeHavuzu.AsamaNoAzalt(_kelime);
        }
        public void AddNewItem(Kelimeler kelimeDepo)
        {
            _kelimeHavuzu.AddNewItem(kelimeDepo);
        }
        public void DeleteItem(Kelimeler kelimeHavuzu)
        {
            _kelimeHavuzu.DeleteItem(kelimeHavuzu);
        }
    }
}
