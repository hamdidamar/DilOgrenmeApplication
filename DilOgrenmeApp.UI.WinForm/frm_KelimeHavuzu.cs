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
    public partial class frm_KelimeHavuzu : Form
    {
        public frm_KelimeHavuzu()
        {
            InitializeComponent();
        }
        KelimeBLL bll = new KelimeBLL();
        Kelimeler _kelime = new Kelimeler();
        private void frm_KelimeHavuzu_Load(object sender, EventArgs e)
        {
            dtgrd_KelimeHavuzu.DataSource = bll.GetAllItems(_kelime);
        }
    }
}
