namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_KelimeIslemleri
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_KelimeSilId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_KEFotoYolu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_KelimeEkle = new System.Windows.Forms.Button();
            this.txt_Kategori = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_KESozcukTuru = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_KETurkceCumle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_KEİngilizceCumle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KETurkce = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KEİngilizce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgrd_KelimeIslemleri = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_KelimeIslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lütfen Kelime ID Giriniz";
            // 
            // txt_KelimeSilId
            // 
            this.txt_KelimeSilId.Location = new System.Drawing.Point(132, 19);
            this.txt_KelimeSilId.Name = "txt_KelimeSilId";
            this.txt_KelimeSilId.Size = new System.Drawing.Size(64, 20);
            this.txt_KelimeSilId.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kelime Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_KelimeSilId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(406, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 99);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelime Sil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_KEFotoYolu);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_KelimeEkle);
            this.groupBox2.Controls.Add(this.txt_Kategori);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_KESozcukTuru);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_KETurkceCumle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_KEİngilizceCumle);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_KETurkce);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_KEİngilizce);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(-2, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 278);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kelime Ekle";
            // 
            // txt_KEFotoYolu
            // 
            this.txt_KEFotoYolu.Location = new System.Drawing.Point(161, 169);
            this.txt_KEFotoYolu.Name = "txt_KEFotoYolu";
            this.txt_KEFotoYolu.Size = new System.Drawing.Size(150, 20);
            this.txt_KEFotoYolu.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Lütfen Fotoğraf Yolu Giriniz";
            // 
            // btn_KelimeEkle
            // 
            this.btn_KelimeEkle.Location = new System.Drawing.Point(12, 220);
            this.btn_KelimeEkle.Name = "btn_KelimeEkle";
            this.btn_KelimeEkle.Size = new System.Drawing.Size(106, 23);
            this.btn_KelimeEkle.TabIndex = 16;
            this.btn_KelimeEkle.Text = "Kelime Ekle";
            this.btn_KelimeEkle.UseVisualStyleBackColor = true;
            this.btn_KelimeEkle.Click += new System.EventHandler(this.btn_KelimeEkle_Click);
            // 
            // txt_Kategori
            // 
            this.txt_Kategori.Location = new System.Drawing.Point(161, 192);
            this.txt_Kategori.Name = "txt_Kategori";
            this.txt_Kategori.Size = new System.Drawing.Size(150, 20);
            this.txt_Kategori.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lütfen Kategori Giriniz";
            // 
            // txt_KESozcukTuru
            // 
            this.txt_KESozcukTuru.Location = new System.Drawing.Point(161, 141);
            this.txt_KESozcukTuru.Name = "txt_KESozcukTuru";
            this.txt_KESozcukTuru.Size = new System.Drawing.Size(150, 20);
            this.txt_KESozcukTuru.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lütfen Sözcük Türü Giriniz";
            // 
            // txt_KETurkceCumle
            // 
            this.txt_KETurkceCumle.Location = new System.Drawing.Point(161, 115);
            this.txt_KETurkceCumle.Name = "txt_KETurkceCumle";
            this.txt_KETurkceCumle.Size = new System.Drawing.Size(150, 20);
            this.txt_KETurkceCumle.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lütfen Türkçe Cümle Giriniz";
            // 
            // txt_KEİngilizceCumle
            // 
            this.txt_KEİngilizceCumle.Location = new System.Drawing.Point(161, 83);
            this.txt_KEİngilizceCumle.Name = "txt_KEİngilizceCumle";
            this.txt_KEİngilizceCumle.Size = new System.Drawing.Size(150, 20);
            this.txt_KEİngilizceCumle.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lütfen İngilizce Cümle Giriniz";
            // 
            // txt_KETurkce
            // 
            this.txt_KETurkce.Location = new System.Drawing.Point(161, 48);
            this.txt_KETurkce.Name = "txt_KETurkce";
            this.txt_KETurkce.Size = new System.Drawing.Size(150, 20);
            this.txt_KETurkce.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lütfen Türkçe Kelime  Giriniz";
            // 
            // txt_KEİngilizce
            // 
            this.txt_KEİngilizce.Location = new System.Drawing.Point(161, 21);
            this.txt_KEİngilizce.Name = "txt_KEİngilizce";
            this.txt_KEİngilizce.Size = new System.Drawing.Size(150, 20);
            this.txt_KEİngilizce.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lütfen İngilizce Kelime  Giriniz";
            // 
            // dtgrd_KelimeIslemleri
            // 
            this.dtgrd_KelimeIslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_KelimeIslemleri.Location = new System.Drawing.Point(406, 115);
            this.dtgrd_KelimeIslemleri.Name = "dtgrd_KelimeIslemleri";
            this.dtgrd_KelimeIslemleri.Size = new System.Drawing.Size(240, 150);
            this.dtgrd_KelimeIslemleri.TabIndex = 5;
            // 
            // frm_Kelimeİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 288);
            this.Controls.Add(this.dtgrd_KelimeIslemleri);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_Kelimeİslemleri";
            this.Text = "Kelime İslemleri";
            this.Load += new System.EventHandler(this.frm_Kelimeİslemleri_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_KelimeIslemleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_KelimeSilId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_KelimeEkle;
        private System.Windows.Forms.TextBox txt_Kategori;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_KESozcukTuru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_KETurkceCumle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_KEİngilizceCumle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_KETurkce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KEİngilizce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KEFotoYolu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dtgrd_KelimeIslemleri;
    }
}