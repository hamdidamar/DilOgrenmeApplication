using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DilOgrenmeApp.UI.WinForm
{
    public partial class frm_GenelSayfa : Form
    {
        public frm_GenelSayfa()
        {
            InitializeComponent();
        }
        frm_KelimeHavuzu KelimeHavuzu;
        frm_AnaSayfa AnaSayfa;
        frm_KelimeOgren KelimeOgren;
        frm_KelimeIslemleri KelimeIslemleri;
        frm_OgrenilecekKelimeler OgrenilecekKelimeler;
        frm_OgrendigimKelimeler OgrendigimKelimeler;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (KelimeHavuzu == null || KelimeHavuzu.IsDisposed)
            {
                KelimeHavuzu = new frm_KelimeHavuzu();
                KelimeHavuzu.MdiParent = this;
                KelimeHavuzu.Show();
            }
            else
            {
                MessageBox.Show("Kelime Havuzu Zaten Açık..");
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (AnaSayfa == null || AnaSayfa.IsDisposed)
            {
                AnaSayfa = new frm_AnaSayfa();
                AnaSayfa.MdiParent = this;
                AnaSayfa.Show();
            }
            else
            {
                MessageBox.Show("Ana Sayfa Zaten Açık..");
            }
            
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (KelimeOgren == null || KelimeOgren.IsDisposed)
            {
                KelimeOgren = new frm_KelimeOgren();
                KelimeOgren.MdiParent = this;
                KelimeOgren.Show();
            }
            else
            {
                MessageBox.Show("Kelime Öğren Zaten Açık..");
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (KelimeIslemleri == null || KelimeIslemleri.IsDisposed)
            {
                KelimeIslemleri = new frm_KelimeIslemleri();
                KelimeIslemleri.MdiParent = this;
                KelimeIslemleri.Show();
            }
            else
            {
                MessageBox.Show("Kelime İşlemleri Zaten Açık..");
            }

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (OgrenilecekKelimeler == null || OgrenilecekKelimeler.IsDisposed)
            {
                OgrenilecekKelimeler = new frm_OgrenilecekKelimeler();
                OgrenilecekKelimeler.MdiParent = this;
                OgrenilecekKelimeler.Show();
            }
            else
            {
                MessageBox.Show("Öğrenilecek Kelimeler Zaten Açık..");
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (OgrendigimKelimeler == null || OgrendigimKelimeler.IsDisposed)
            {
                OgrendigimKelimeler = new frm_OgrendigimKelimeler();
                OgrendigimKelimeler.MdiParent = this;
                OgrendigimKelimeler.Show();
            }
            else
            {
                MessageBox.Show("Öğrenilecek Kelimeler Zaten Açık..");
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
