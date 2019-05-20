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
    public partial class frm_OgrenilecekKelimeler : Form
    {
        public frm_OgrenilecekKelimeler()
        {
            InitializeComponent();
        }
        KelimeBLL bll = new KelimeBLL();
        Kelimeler _kelime = new Kelimeler();
        private void frm_OgrenilecekKelimeler_Load(object sender, EventArgs e)
        {
            //dgAyarlari
            dtgrid_OgrenilecekKelimeler.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dtgrid_OgrenilecekKelimeler.RowHeadersVisible = false;
            dtgrid_OgrenilecekKelimeler.ReadOnly = true;
            dtgrid_OgrenilecekKelimeler.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgrid_OgrenilecekKelimeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgrid_OgrenilecekKelimeler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgrid_OgrenilecekKelimeler.MultiSelect = false;
            dtgrid_OgrenilecekKelimeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgrid_OgrenilecekKelimeler.AllowUserToAddRows = false;

            dtgrid_OgrenilecekKelimeler.DataSource = bll.GetOgrenilecekKelimeler(_kelime);

        }

        private void btn_OgrenileceklereEkle_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dtgrid_OgrenilecekKelimeler.CurrentRow.Cells["turkce"].Value.ToString());
            _kelime.turkce = dtgrid_OgrenilecekKelimeler.CurrentRow.Cells["turkce"].Value.ToString();
            bll.AsamaNoArttir(_kelime);
        }
    }
}
