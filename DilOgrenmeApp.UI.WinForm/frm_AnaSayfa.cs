using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DilOgrenmeApp.BLL;
using DilOgrenmeApp.Entity;

namespace DilOgrenmeApp.UI.WinForm
{
    public partial class frm_AnaSayfa : Form
    {
        public frm_AnaSayfa()
        {
            InitializeComponent();
        }

        List<Kelimeler> kelimeGelen = new List<Kelimeler>();
        Kelimeler _kelime = new Kelimeler();
        KelimeBLL bll = new KelimeBLL();
        Random rand = new Random();
        List<string> rastgelecevap = new List<string>();
        string dogrucevap = "";
        private void btn_TestYap_Click(object sender, EventArgs e)
        {
            //Seçili Olan Cevabı konrtol işlemleri,Aşama Numarası Güncelleme ve Tarih Güncelleme İşlemlerinin Yapıldığı Yer 
            _kelime.turkce = dogrucevap;
            if (rdbtn_A.Checked == true)
            {

                if (rdbtn_A.Text.ToLower() == dogrucevap.ToLower())
                {
                    MessageBox.Show("Tebrikler Doğru Cevap");
                    bll.AsamaNoArttir(_kelime);
                    bll.tarihGuncelle(_kelime);
                }
                else
                {
                    MessageBox.Show("Malesef Yanlış Cevap :( Yarın Tekrar Deneyin");
                    bll.AsamaNoAzalt(_kelime);
                    bll.tarihGuncelle(_kelime);
                }
            }
            if (rdbtn_B.Checked == true)
            {

                if (rdbtn_B.Text.ToLower() == dogrucevap.ToLower())
                {
                    MessageBox.Show("Tebrikler Doğru Cevap");
                    bll.AsamaNoArttir(_kelime);
                    bll.tarihGuncelle(_kelime);
                }
                else
                {
                    MessageBox.Show("Malesef Yanlış Cevap :( Yarın Tekrar Deneyin");
                    bll.AsamaNoAzalt(_kelime);
                    bll.tarihGuncelle(_kelime);
                }
            }
            if (rdbtn_C.Checked == true)
            {

                if (rdbtn_C.Text.ToLower() == dogrucevap.ToLower())
                {
                    MessageBox.Show("Tebrikler Doğru Cevap");
                    bll.AsamaNoArttir(_kelime);
                   bll.tarihGuncelle(_kelime);
                }
                else
                {
                    MessageBox.Show("Malesef Yanlış Cevap :( Yarın Tekrar Deneyin");
                    bll.AsamaNoAzalt(_kelime);
                    bll.tarihGuncelle(_kelime);
                }
            }
            if (rdbtn_D.Checked == true)
            {

                if (rdbtn_D.Text.ToLower() == dogrucevap.ToLower())
                {
                    MessageBox.Show("Tebrikler Doğru Cevap");
                    bll.AsamaNoArttir(_kelime);
                    bll.tarihGuncelle(_kelime);
                }
                else
                {
                    MessageBox.Show("Malesef Yanlış Cevap :( Yarın Tekrar Deneyin");
                    bll.AsamaNoAzalt(_kelime);
                    bll.tarihGuncelle(_kelime);
                }
            }

           
            try
            {
                //O Gün Tarihindeki Sorulacak Kelimeleri Getirip Şıkların Rastgele Sorulmasını Sağlanan Yer
                List<string> tempKelime = new List<string>();
                string[] rastGetir = new string[4];
                kelimeGelen = bll.GetRandItem(_kelime);
                tempKelime.Add(kelimeGelen[0].turkce);
                lbl_IngilizceTest.Text = kelimeGelen[0].ingilizce;
                dogrucevap = _kelime.turkce;
                kelimeGelen = bll.GetRandItem(_kelime);
                tempKelime.Add(kelimeGelen[0].turkce);
                kelimeGelen = bll.GetRandItem(_kelime);
                tempKelime.Add(kelimeGelen[0].turkce);
                kelimeGelen = bll.GetRandItem(_kelime);
                tempKelime.Add(kelimeGelen[0].turkce);

                for (int i = 0; i < 4; i++)
                {
                    int sayi = rand.Next(0, 3 - i);
                    Console.WriteLine(sayi);
                    rastGetir[i] = tempKelime[sayi];
                    tempKelime.RemoveAt(sayi);

                }
                rdbtn_A.Text = rastGetir[0];
                rdbtn_B.Text = rastGetir[1];
                rdbtn_C.Text = rastGetir[2];
                rdbtn_D.Text = rastGetir[3];
            }
            catch (Exception)
            {
                grpboxTest.Visible = false;
                MessageBox.Show("Başka Sorunuz Kalmadı :)");
            }
            
            

        }

        private void frm_AnaSayfa_Load(object sender, EventArgs e)
        {
            try
            {
                cmbbox_Aylik.Visible = false;
                cmbbox_Yillik.Visible = false;
                kelimeGelen = bll.GetRandItem(_kelime);
                lbl_IngilizceTest.Text = kelimeGelen[0].ingilizce;
                dogrucevap = _kelime.turkce;
                rdbtn_A.Text = kelimeGelen[0].turkce;
                kelimeGelen = bll.GetRandItem(_kelime);
                rdbtn_B.Text = kelimeGelen[0].turkce;
                kelimeGelen = bll.GetRandItem(_kelime);
                rdbtn_C.Text = kelimeGelen[0].turkce;
                kelimeGelen = bll.GetRandItem(_kelime);
                rdbtn_D.Text = kelimeGelen[0].turkce;
            }
            catch (Exception)
            {
                grpboxTest.Visible = false;
                MessageBox.Show("Bugün Sorunuz Yok :)");
            }
            

        }
        DataTable kgelen = new DataTable();
        private void btn_İstatistlikGoster_Click(object sender, EventArgs e)
        {
            //Istatislik Sorgulam Yaptığımız Yer
            listboxIstatistlik.Items.Clear();
            kgelen = bll.AylikIstatistikGetir();
            _kelime.sormaTarihi= kgelen.Rows[0].Field<string>("sormaTarihi");
            string tarih;
            string[] tarihBolum = new string[3];
            
            if (rdiobtn_AylikIstatistlik.Checked == true)
            {
                
                for (int i = 0; i < kgelen.Rows.Count; i++)
                {
                    _kelime.ingilizce = kgelen.Rows[i].Field<string>("ingilizce");
                    _kelime.turkce = kgelen.Rows[i].Field<string>("turkce");
                    tarih = kgelen.Rows[i].Field<string>("sormaTarihi");
                    tarihBolum = tarih.Split('.');
                    if ((int.Parse(tarihBolum[1]) == cmbbox_Aylik.SelectedIndex + 1) && (tarihBolum[2]) == cmbbox_Yillik.Text)
                    {
                        listboxIstatistlik.Items.Add(_kelime.ingilizce + "\t\t" + _kelime.turkce + "\t\t" + tarih);
                    }

                }
            }
            else if (rdiobtn_YillikIstatistlik.Checked == true)
            {
               
                for (int i = 0; i < kgelen.Rows.Count; i++)
                {
                    _kelime.ingilizce = kgelen.Rows[i].Field<string>("ingilizce");
                    _kelime.turkce = kgelen.Rows[i].Field<string>("turkce");
                    tarih = kgelen.Rows[i].Field<string>("sormaTarihi");
                    tarihBolum = tarih.Split('.');
                    if (tarihBolum[2] == cmbbox_Yillik.Text)
                    {
                        listboxIstatistlik.Items.Add(_kelime.ingilizce + "\t\t" + _kelime.turkce + "\t\t" + tarih);
                    }

                }
            }
            lbl_OgrenilenKelime.Text = listboxIstatistlik.Items.Count.ToString();
            prgrsbr_İlerlemeDurumu.Maximum = 100;
            prgrsbr_İlerlemeDurumu.Value = listboxIstatistlik.Items.Count;
            
        }
        
        private void rdiobtn_YillikIstatistlik_CheckedChanged(object sender, EventArgs e)
        {
            cmbbox_Yillik.Visible = true;
            cmbbox_Aylik.Visible = false;
        }

        private void rdiobtn_AylikIstatistlik_CheckedChanged(object sender, EventArgs e)
        {
            cmbbox_Aylik.Visible = true;
            cmbbox_Yillik.Visible = true;
        }
    }
}
