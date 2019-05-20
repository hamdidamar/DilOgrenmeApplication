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
    public partial class frm_KelimeIslemleri : Form
    {
        public frm_KelimeIslemleri()
        {
            InitializeComponent();
        }
        Kelimeler _kelimeHavuzu;
        private void button1_Click(object sender, EventArgs e)
        {
            _kelimeHavuzu = new Kelimeler();
            KelimeBLL bll = new KelimeBLL();
            _kelimeHavuzu.Id = Convert.ToInt32(txt_KelimeSilId.Text);
            bll.DeleteItem(_kelimeHavuzu);
            MessageBox.Show("Kelime Başarı ile Silindi..");
        }
        KelimeBLL bll = new KelimeBLL();
        List<Kelimeler> GenelKelimeler = new List<Kelimeler>();
        private void btn_KelimeEkle_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < GenelKelimeler.Count; i++)
            {
                if (GenelKelimeler[0].ingilizce == txt_KEİngilizce.Text)
                {
                    MessageBox.Show("Eklemek istediğiniz kelime zaten var !!");
                }
                else
                    MessageBox.Show("Hata");
            }
            _kelimeHavuzu = new Kelimeler();
            _kelimeHavuzu.ingilizce = txt_KEİngilizce.Text;
            _kelimeHavuzu.turkce = txt_KETurkce.Text;
            _kelimeHavuzu.icumle = txt_KEİngilizceCumle.Text;
            _kelimeHavuzu.tcumle = txt_KETurkceCumle.Text;
            _kelimeHavuzu.sozcukturu = txt_KESozcukTuru.Text;
            _kelimeHavuzu.fotoyolu = txt_KEFotoYolu.Text;
            _kelimeHavuzu.kategori = txt_Kategori.Text;
            try
            {
                
                bll.AddNewItem(_kelimeHavuzu);
                MessageBox.Show("Kelime Başarı ile Eklendi..");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);;
            }
        }

        private void frm_Kelimeİslemleri_Load(object sender, EventArgs e)
        {
            Kelimeler _kelime = new Kelimeler();
            dtgrd_KelimeIslemleri.DataSource = bll.GetAllItems(_kelime);
        }
    }
}
