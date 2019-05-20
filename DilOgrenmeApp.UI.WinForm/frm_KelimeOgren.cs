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
    public partial class frm_KelimeOgren : Form
    {
        public frm_KelimeOgren()
        {
            InitializeComponent();
        }

        List<Kelimeler> kelimeGelen = new List<Kelimeler>();
        Kelimeler _kelime = new Kelimeler();
        KelimeBLL bll = new KelimeBLL();
        private void frm_KelimeOgren_Load(object sender, EventArgs e)
        {
            kelimeGelen = bll.GetOgrenilecekItem(_kelime);
            lbl_Gİngilizce.Text = kelimeGelen[0].ingilizce;
            lbl_GTurkce.Text = kelimeGelen[0].turkce;
            lbl_GİngilizceC.Text = kelimeGelen[0].icumle;
            lbl_GTurkceC.Text = kelimeGelen[0].turkce;
            lbl_GSozcukTuru.Text = kelimeGelen[0].sozcukturu;
            lbl_GKategori.Text = kelimeGelen[0].kategori;
        }

        private void btn_Ogren_Click(object sender, EventArgs e)
        {
            kelimeGelen = bll.GetOgrenilecekItem(_kelime);
            lbl_Gİngilizce.Text = kelimeGelen[0].ingilizce;
            lbl_GTurkce.Text = kelimeGelen[0].turkce;
            lbl_GİngilizceC.Text = kelimeGelen[0].icumle;
            lbl_GTurkceC.Text = kelimeGelen[0].turkce;
            lbl_GSozcukTuru.Text = kelimeGelen[0].sozcukturu;
            lbl_GKategori.Text = kelimeGelen[0].kategori;
            _kelime.turkce = lbl_GTurkce.Text;
            bll.AsamaNoArttir(_kelime);
            _kelime.sormaTarihi = DateTime.Now.AddDays(1).ToShortDateString();
            _kelime.ingilizce = kelimeGelen[0].ingilizce;
            bll.tarihGuncelle(_kelime);

        }
    }
}
