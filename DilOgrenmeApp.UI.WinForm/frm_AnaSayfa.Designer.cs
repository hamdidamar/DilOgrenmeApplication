namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_TestYap = new System.Windows.Forms.Button();
            this.rdbtn_A = new System.Windows.Forms.RadioButton();
            this.rdbtn_B = new System.Windows.Forms.RadioButton();
            this.rdbtn_C = new System.Windows.Forms.RadioButton();
            this.rdbtn_D = new System.Windows.Forms.RadioButton();
            this.lbl_IngilizceTest = new System.Windows.Forms.Label();
            this.cmbbox_Aylik = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbbox_Yillik = new System.Windows.Forms.ComboBox();
            this.btn_İstatistlikGoster = new System.Windows.Forms.Button();
            this.grpboxTest = new System.Windows.Forms.GroupBox();
            this.rdiobtn_AylikIstatistlik = new System.Windows.Forms.RadioButton();
            this.rdiobtn_YillikIstatistlik = new System.Windows.Forms.RadioButton();
            this.listboxIstatistlik = new System.Windows.Forms.ListBox();
            this.prgrsbr_İlerlemeDurumu = new System.Windows.Forms.ProgressBar();
            this.lbl_ilerleme = new System.Windows.Forms.Label();
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.lbl_OgrenilenKelime = new System.Windows.Forms.Label();
            this.grpboxTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TestYap
            // 
            this.btn_TestYap.Location = new System.Drawing.Point(57, 204);
            this.btn_TestYap.Name = "btn_TestYap";
            this.btn_TestYap.Size = new System.Drawing.Size(150, 23);
            this.btn_TestYap.TabIndex = 3;
            this.btn_TestYap.Text = "Test Yap";
            this.btn_TestYap.UseVisualStyleBackColor = true;
            this.btn_TestYap.Click += new System.EventHandler(this.btn_TestYap_Click);
            // 
            // rdbtn_A
            // 
            this.rdbtn_A.AutoSize = true;
            this.rdbtn_A.Location = new System.Drawing.Point(57, 106);
            this.rdbtn_A.Name = "rdbtn_A";
            this.rdbtn_A.Size = new System.Drawing.Size(32, 17);
            this.rdbtn_A.TabIndex = 4;
            this.rdbtn_A.TabStop = true;
            this.rdbtn_A.Text = "A";
            this.rdbtn_A.UseVisualStyleBackColor = true;
            // 
            // rdbtn_B
            // 
            this.rdbtn_B.AutoSize = true;
            this.rdbtn_B.Location = new System.Drawing.Point(193, 106);
            this.rdbtn_B.Name = "rdbtn_B";
            this.rdbtn_B.Size = new System.Drawing.Size(32, 17);
            this.rdbtn_B.TabIndex = 5;
            this.rdbtn_B.TabStop = true;
            this.rdbtn_B.Text = "B";
            this.rdbtn_B.UseVisualStyleBackColor = true;
            // 
            // rdbtn_C
            // 
            this.rdbtn_C.AutoSize = true;
            this.rdbtn_C.Location = new System.Drawing.Point(57, 149);
            this.rdbtn_C.Name = "rdbtn_C";
            this.rdbtn_C.Size = new System.Drawing.Size(32, 17);
            this.rdbtn_C.TabIndex = 6;
            this.rdbtn_C.TabStop = true;
            this.rdbtn_C.Text = "C";
            this.rdbtn_C.UseVisualStyleBackColor = true;
            // 
            // rdbtn_D
            // 
            this.rdbtn_D.AutoSize = true;
            this.rdbtn_D.Location = new System.Drawing.Point(193, 149);
            this.rdbtn_D.Name = "rdbtn_D";
            this.rdbtn_D.Size = new System.Drawing.Size(33, 17);
            this.rdbtn_D.TabIndex = 7;
            this.rdbtn_D.TabStop = true;
            this.rdbtn_D.Text = "D";
            this.rdbtn_D.UseVisualStyleBackColor = true;
            // 
            // lbl_IngilizceTest
            // 
            this.lbl_IngilizceTest.AutoSize = true;
            this.lbl_IngilizceTest.Location = new System.Drawing.Point(90, 70);
            this.lbl_IngilizceTest.Name = "lbl_IngilizceTest";
            this.lbl_IngilizceTest.Size = new System.Drawing.Size(76, 13);
            this.lbl_IngilizceTest.TabIndex = 8;
            this.lbl_IngilizceTest.Text = "İngilizce Gelen";
            // 
            // cmbbox_Aylik
            // 
            this.cmbbox_Aylik.FormattingEnabled = true;
            this.cmbbox_Aylik.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmbbox_Aylik.Location = new System.Drawing.Point(398, 247);
            this.cmbbox_Aylik.Name = "cmbbox_Aylik";
            this.cmbbox_Aylik.Size = new System.Drawing.Size(121, 21);
            this.cmbbox_Aylik.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ay seçiniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Yıl seçiniz";
            // 
            // cmbbox_Yillik
            // 
            this.cmbbox_Yillik.FormattingEnabled = true;
            this.cmbbox_Yillik.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cmbbox_Yillik.Location = new System.Drawing.Point(584, 247);
            this.cmbbox_Yillik.Name = "cmbbox_Yillik";
            this.cmbbox_Yillik.Size = new System.Drawing.Size(63, 21);
            this.cmbbox_Yillik.TabIndex = 11;
            // 
            // btn_İstatistlikGoster
            // 
            this.btn_İstatistlikGoster.Location = new System.Drawing.Point(367, 271);
            this.btn_İstatistlikGoster.Name = "btn_İstatistlikGoster";
            this.btn_İstatistlikGoster.Size = new System.Drawing.Size(263, 26);
            this.btn_İstatistlikGoster.TabIndex = 14;
            this.btn_İstatistlikGoster.Text = "İstatistlik Listele";
            this.btn_İstatistlikGoster.UseVisualStyleBackColor = true;
            this.btn_İstatistlikGoster.Click += new System.EventHandler(this.btn_İstatistlikGoster_Click);
            // 
            // grpboxTest
            // 
            this.grpboxTest.Controls.Add(this.btn_TestYap);
            this.grpboxTest.Controls.Add(this.rdbtn_A);
            this.grpboxTest.Controls.Add(this.rdbtn_B);
            this.grpboxTest.Controls.Add(this.rdbtn_C);
            this.grpboxTest.Controls.Add(this.rdbtn_D);
            this.grpboxTest.Controls.Add(this.lbl_IngilizceTest);
            this.grpboxTest.Location = new System.Drawing.Point(12, 12);
            this.grpboxTest.Name = "grpboxTest";
            this.grpboxTest.Size = new System.Drawing.Size(292, 296);
            this.grpboxTest.TabIndex = 15;
            this.grpboxTest.TabStop = false;
            this.grpboxTest.Text = "Bugün Test Soruları";
            // 
            // rdiobtn_AylikIstatistlik
            // 
            this.rdiobtn_AylikIstatistlik.AutoSize = true;
            this.rdiobtn_AylikIstatistlik.Location = new System.Drawing.Point(344, 224);
            this.rdiobtn_AylikIstatistlik.Name = "rdiobtn_AylikIstatistlik";
            this.rdiobtn_AylikIstatistlik.Size = new System.Drawing.Size(90, 17);
            this.rdiobtn_AylikIstatistlik.TabIndex = 16;
            this.rdiobtn_AylikIstatistlik.TabStop = true;
            this.rdiobtn_AylikIstatistlik.Text = "Aylık İstatistlik";
            this.rdiobtn_AylikIstatistlik.UseVisualStyleBackColor = true;
            this.rdiobtn_AylikIstatistlik.CheckedChanged += new System.EventHandler(this.rdiobtn_AylikIstatistlik_CheckedChanged);
            // 
            // rdiobtn_YillikIstatistlik
            // 
            this.rdiobtn_YillikIstatistlik.AutoSize = true;
            this.rdiobtn_YillikIstatistlik.Location = new System.Drawing.Point(528, 224);
            this.rdiobtn_YillikIstatistlik.Name = "rdiobtn_YillikIstatistlik";
            this.rdiobtn_YillikIstatistlik.Size = new System.Drawing.Size(92, 17);
            this.rdiobtn_YillikIstatistlik.TabIndex = 17;
            this.rdiobtn_YillikIstatistlik.TabStop = true;
            this.rdiobtn_YillikIstatistlik.Text = "Yıllık İstatistlik ";
            this.rdiobtn_YillikIstatistlik.UseVisualStyleBackColor = true;
            this.rdiobtn_YillikIstatistlik.CheckedChanged += new System.EventHandler(this.rdiobtn_YillikIstatistlik_CheckedChanged);
            // 
            // listboxIstatistlik
            // 
            this.listboxIstatistlik.FormattingEnabled = true;
            this.listboxIstatistlik.Location = new System.Drawing.Point(337, 25);
            this.listboxIstatistlik.Name = "listboxIstatistlik";
            this.listboxIstatistlik.Size = new System.Drawing.Size(319, 121);
            this.listboxIstatistlik.TabIndex = 18;
            // 
            // prgrsbr_İlerlemeDurumu
            // 
            this.prgrsbr_İlerlemeDurumu.Location = new System.Drawing.Point(483, 157);
            this.prgrsbr_İlerlemeDurumu.Name = "prgrsbr_İlerlemeDurumu";
            this.prgrsbr_İlerlemeDurumu.Size = new System.Drawing.Size(159, 26);
            this.prgrsbr_İlerlemeDurumu.TabIndex = 19;
            // 
            // lbl_ilerleme
            // 
            this.lbl_ilerleme.AutoSize = true;
            this.lbl_ilerleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ilerleme.Location = new System.Drawing.Point(337, 160);
            this.lbl_ilerleme.Name = "lbl_ilerleme";
            this.lbl_ilerleme.Size = new System.Drawing.Size(140, 22);
            this.lbl_ilerleme.TabIndex = 20;
            this.lbl_ilerleme.Text = "İlerleme Durumu";
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.AutoSize = true;
            this.lbl_kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelime.Location = new System.Drawing.Point(339, 194);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(216, 17);
            this.lbl_kelime.TabIndex = 21;
            this.lbl_kelime.Text = "Toplam Öğrenilen Kelime Sayısı :";
            // 
            // lbl_OgrenilenKelime
            // 
            this.lbl_OgrenilenKelime.AutoSize = true;
            this.lbl_OgrenilenKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_OgrenilenKelime.Location = new System.Drawing.Point(555, 194);
            this.lbl_OgrenilenKelime.Name = "lbl_OgrenilenKelime";
            this.lbl_OgrenilenKelime.Size = new System.Drawing.Size(24, 17);
            this.lbl_OgrenilenKelime.TabIndex = 22;
            this.lbl_OgrenilenKelime.Text = "00";
            // 
            // frm_AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 320);
            this.Controls.Add(this.lbl_OgrenilenKelime);
            this.Controls.Add(this.lbl_kelime);
            this.Controls.Add(this.lbl_ilerleme);
            this.Controls.Add(this.prgrsbr_İlerlemeDurumu);
            this.Controls.Add(this.listboxIstatistlik);
            this.Controls.Add(this.rdiobtn_YillikIstatistlik);
            this.Controls.Add(this.rdiobtn_AylikIstatistlik);
            this.Controls.Add(this.grpboxTest);
            this.Controls.Add(this.btn_İstatistlikGoster);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbbox_Yillik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbbox_Aylik);
            this.Name = "frm_AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.frm_AnaSayfa_Load);
            this.grpboxTest.ResumeLayout(false);
            this.grpboxTest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_TestYap;
        private System.Windows.Forms.RadioButton rdbtn_A;
        private System.Windows.Forms.RadioButton rdbtn_B;
        private System.Windows.Forms.RadioButton rdbtn_C;
        private System.Windows.Forms.RadioButton rdbtn_D;
        private System.Windows.Forms.Label lbl_IngilizceTest;
        private System.Windows.Forms.ComboBox cmbbox_Aylik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbbox_Yillik;
        private System.Windows.Forms.Button btn_İstatistlikGoster;
        private System.Windows.Forms.GroupBox grpboxTest;
        private System.Windows.Forms.RadioButton rdiobtn_AylikIstatistlik;
        private System.Windows.Forms.RadioButton rdiobtn_YillikIstatistlik;
        private System.Windows.Forms.ListBox listboxIstatistlik;
        private System.Windows.Forms.ProgressBar prgrsbr_İlerlemeDurumu;
        private System.Windows.Forms.Label lbl_ilerleme;
        private System.Windows.Forms.Label lbl_kelime;
        private System.Windows.Forms.Label lbl_OgrenilenKelime;
    }
}