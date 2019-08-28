using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DilOgrenmeApp.Entity;
using System.Text.RegularExpressions;


namespace DilOgrenmeApp.DAL
{
   public class KelimeHavuzuDAL
    {
        private DBHelper dbHelper;
  
        public KelimeHavuzuDAL()
        {
            dbHelper = new DBHelper();
        }
        public DataTable GetAllItems(Kelimeler _kelime)
        {

            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT * FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {

                _kelime.ingilizce = dt.Rows[0].Field<string>("ingilizce");
                _kelime.turkce = dt.Rows[0].Field<string>("turkce");
                _kelime.icumle = dt.Rows[0].Field<string>("icumle");
                _kelime.tcumle = dt.Rows[0].Field<string>("tcumle");
                _kelime.sozcukturu = dt.Rows[0].Field<string>("sozcukturu");
                _kelime.kategori = dt.Rows[0].Field<string>("kategori");
            }
            return dt;
        }
        public List<Kelimeler> GetRandItem(Kelimeler _kelime)
        {

            SqlCommand cmd = dbHelper.GetSqlCommand();
            _kelime.bugunTarihi = DateTime.Now.ToShortDateString();
            cmd.CommandText = ("SELECT TOP 4 ID,ingilizce,turkce,asamaNo FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu WHERE asamaNo <= 5 and asamaNo >=0 and sormaTarihi=@bugunTarihi ORDER BY NEWID() ");
            cmd.Parameters.AddWithValue("@bugunTarihi",_kelime.bugunTarihi);
            cmd.ExecuteNonQuery();
            List<Kelimeler> listKelimeler = new List<Kelimeler>();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                _kelime.ingilizce = rdr["ingilizce"].ToString();
                _kelime.turkce = rdr["turkce"].ToString();
                listKelimeler.Add(_kelime);
                
            }
            return listKelimeler;
        }
        public DataTable GetOgrendigimKelimeler(Kelimeler _kelime)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT ID,ingilizce,turkce,icumle,tcumle,sozcukturu,kategori,asamaNo FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu WHERE asamaNo >=5";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        public DataTable GetOgrenilecekKelimeler(Kelimeler _kelime)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT ID,ingilizce,turkce,icumle,tcumle,sozcukturu,kategori,asamaNo FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu WHERE asamaNo=0";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable AylikIstatistlikGetir()
        {
            Kelimeler _kelime = new Kelimeler();
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT ingilizce,turkce,sormaTarihi FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu WHERE asamaNo>=5 ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public DataTable YillikIstatistlikGetir(int yil)
        {

            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT ID,ingilizce,turkce,icumle,tcumle,sozcukturu,kategori,asamaNo"
                + "FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu "
                + " where asamaNo >=5 and YEAR(sormaTarihi)=" + yil.ToString();
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public List<Kelimeler> GetOgrenilecekItem(Kelimeler _kelime)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = "SELECT TOP 1  ingilizce,turkce,icumle,tcumle,sozcukturu,kategori,sormaTarihi "
                +"FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu"
                +" WHERE asamaNo = 1 ORDER BY NEWID() ";
            cmd.ExecuteNonQuery();
            List<Kelimeler> listKelimeler = new List<Kelimeler>();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                _kelime.ingilizce = rdr["ingilizce"].ToString();
                _kelime.turkce = rdr["turkce"].ToString();
                _kelime.icumle = rdr["icumle"].ToString();
                _kelime.tcumle = rdr["tcumle"].ToString();
                _kelime.sozcukturu = rdr["sozcukturu"].ToString();
                _kelime.kategori = rdr["kategori"].ToString();
                _kelime.sormaTarihi =rdr["sormaTarihi"].ToString();
                listKelimeler.Add(_kelime);

            }
            return listKelimeler;
        }
        public void TarihGuncelle(Kelimeler _kelime)
        {
            SqlCommand kmt = dbHelper.GetSqlCommand();
            kmt.CommandText = ("SELECT ingilizce,turkce,asamaNo FROM DilOgrenmeOtomasyon.dbo.KelimeHavuzu  WHERE turkce=@turkce");
            kmt.Parameters.AddWithValue("@turkce", _kelime.turkce);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                _kelime.ingilizce = dt.Rows[0].Field<string>("ingilizce");
                _kelime.turkce = dt.Rows[0].Field<string>("turkce");
                _kelime.asamaNo = dt.Rows[0].Field<int>("asamaNo").ToString();
                
            }
           
            
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText =( "UPDATE  DilOgrenmeOtomasyon.dbo.KelimeHavuzu SET sormaTarihi = @sormaTarihi WHERE ingilizce=@ingilizce");
            cmd.Parameters.AddWithValue("@sormaTarihi", _kelime.sormaTarihi);
            cmd.Parameters.AddWithValue("@ingilizce", _kelime.ingilizce);
            cmd.ExecuteNonQuery();

            
        }
        public void AsamaNoArttir(Kelimeler _kelime)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = ("UPDATE  DilOgrenmeOtomasyon.dbo.KelimeHavuzu SET asamaNo +=1  WHERE turkce = @turkce");
            cmd.Parameters.AddWithValue("@turkce", _kelime.turkce);
            cmd.ExecuteNonQuery();
        }
        public void AsamaNoAzalt(Kelimeler _kelime)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = ("UPDATE  DilOgrenmeOtomasyon.dbo.KelimeHavuzu SET asamaNo = 1  WHERE turkce = @turkce");
            cmd.Parameters.AddWithValue("@turkce", _kelime.turkce);
            cmd.ExecuteNonQuery();
        }
        public void AddNewItem(Kelimeler _kelime)
        {
            
           string cmdText = string.Format("INSERT INTO DilOgrenmeOtomasyon.dbo.KelimeHavuzu([ingilizce],[turkce],[icumle],[tcumle],[sozcukturu],[fotoyolu],[kategori],[asamaNo]) Values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}',0)",
                _kelime.ingilizce, _kelime.turkce,
                _kelime.icumle, _kelime.tcumle, _kelime.sozcukturu,
                _kelime.fotoyolu, _kelime.kategori,_kelime.asamaNo);
  
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = cmdText;
            cmd.ExecuteNonQuery();
        }
        public void DeleteItem(Kelimeler _kelime)
        {
            SqlCommand cmd = dbHelper.GetSqlCommand();
            cmd.CommandText = string.Format("Delete From DilOgrenmeOtomasyon.dbo.KelimeHavuzu Where ID = @ID");
            cmd.Parameters.AddWithValue("@ID", _kelime.Id);
            cmd.ExecuteNonQuery();
            
        }
      public Datetime kelimeTarihGuncelleme()
      {
          if (_kelime.asamaNo == "1")
                {
                    _kelime.sormaTarihi = DateTime.Now.AddDays(1).ToShortDateString();
                }
                else if (_kelime.asamaNo == "2")
                {
                    _kelime.sormaTarihi = DateTime.Now.AddDays(6).ToShortDateString();
                }
                else if (_kelime.asamaNo == "3")
                {
                    _kelime.sormaTarihi = DateTime.Now.AddDays(23).ToShortDateString();
                }
                else if (_kelime.asamaNo == "4")
                {
                    _kelime.sormaTarihi = DateTime.Now.AddDays(150).ToShortDateString();
                }
                else if (_kelime.asamaNo == "5")
                {
                    _kelime.sormaTarihi = DateTime.Now.AddDays(0).ToShortDateString();
                }
                else if (_kelime.asamaNo == "6")
                {
                    _kelime.sormaTarihi = DateTime.Now.AddDays(0).ToShortDateString();
                }
                else if (_kelime.asamaNo == "0")
                {
                    _kelime.sormaTarihi = DateTime.Now.AddDays(1).ToShortDateString();
                }
         return _kelime.sormaTarihi;
      }
       
    }
}
