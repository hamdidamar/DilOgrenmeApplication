namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_KelimeOgren
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
            this.lbl_Gİngilizce = new System.Windows.Forms.Label();
            this.btn_Ogren = new System.Windows.Forms.Button();
            this.lbl_GTurkce = new System.Windows.Forms.Label();
            this.lbl_GİngilizceC = new System.Windows.Forms.Label();
            this.lbl_GTurkceC = new System.Windows.Forms.Label();
            this.lbl_GSozcukTuru = new System.Windows.Forms.Label();
            this.lbl_GKategori = new System.Windows.Forms.Label();
            this.lbl_KOKategori = new System.Windows.Forms.Label();
            this.lbl_KOSozcukTuru = new System.Windows.Forms.Label();
            this.lbl_KOTurkceCumle = new System.Windows.Forms.Label();
            this.lbl_KOİngilizceCumle = new System.Windows.Forms.Label();
            this.lbl_KOTurkce = new System.Windows.Forms.Label();
            this.lbl_KOİngilizce = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Gİngilizce
            // 
            this.lbl_Gİngilizce.AutoSize = true;
            this.lbl_Gİngilizce.Location = new System.Drawing.Point(198, 22);
            this.lbl_Gİngilizce.Name = "lbl_Gİngilizce";
            this.lbl_Gİngilizce.Size = new System.Drawing.Size(76, 13);
            this.lbl_Gİngilizce.TabIndex = 0;
            this.lbl_Gİngilizce.Text = "İngilizce Gelen";
            // 
            // btn_Ogren
            // 
            this.btn_Ogren.Location = new System.Drawing.Point(27, 215);
            this.btn_Ogren.Name = "btn_Ogren";
            this.btn_Ogren.Size = new System.Drawing.Size(137, 23);
            this.btn_Ogren.TabIndex = 1;
            this.btn_Ogren.Text = "Öğren";
            this.btn_Ogren.UseVisualStyleBackColor = true;
            this.btn_Ogren.Click += new System.EventHandler(this.btn_Ogren_Click);
            // 
            // lbl_GTurkce
            // 
            this.lbl_GTurkce.AutoSize = true;
            this.lbl_GTurkce.Location = new System.Drawing.Point(198, 52);
            this.lbl_GTurkce.Name = "lbl_GTurkce";
            this.lbl_GTurkce.Size = new System.Drawing.Size(72, 13);
            this.lbl_GTurkce.TabIndex = 2;
            this.lbl_GTurkce.Text = "Türkçe Gelen";
            // 
            // lbl_GİngilizceC
            // 
            this.lbl_GİngilizceC.AutoSize = true;
            this.lbl_GİngilizceC.Location = new System.Drawing.Point(200, 79);
            this.lbl_GİngilizceC.Name = "lbl_GİngilizceC";
            this.lbl_GİngilizceC.Size = new System.Drawing.Size(108, 13);
            this.lbl_GİngilizceC.TabIndex = 3;
            this.lbl_GİngilizceC.Text = "İngilizce Cümle Gelen";
            // 
            // lbl_GTurkceC
            // 
            this.lbl_GTurkceC.AutoSize = true;
            this.lbl_GTurkceC.Location = new System.Drawing.Point(200, 111);
            this.lbl_GTurkceC.Name = "lbl_GTurkceC";
            this.lbl_GTurkceC.Size = new System.Drawing.Size(104, 13);
            this.lbl_GTurkceC.TabIndex = 4;
            this.lbl_GTurkceC.Text = "Türkçe Cümle Gelen";
            // 
            // lbl_GSozcukTuru
            // 
            this.lbl_GSozcukTuru.AutoSize = true;
            this.lbl_GSozcukTuru.Location = new System.Drawing.Point(200, 142);
            this.lbl_GSozcukTuru.Name = "lbl_GSozcukTuru";
            this.lbl_GSozcukTuru.Size = new System.Drawing.Size(99, 13);
            this.lbl_GSozcukTuru.TabIndex = 5;
            this.lbl_GSozcukTuru.Text = "Sözcük Türü Gelen";
            // 
            // lbl_GKategori
            // 
            this.lbl_GKategori.AutoSize = true;
            this.lbl_GKategori.Location = new System.Drawing.Point(200, 174);
            this.lbl_GKategori.Name = "lbl_GKategori";
            this.lbl_GKategori.Size = new System.Drawing.Size(77, 13);
            this.lbl_GKategori.TabIndex = 7;
            this.lbl_GKategori.Text = "Kategori Gelen";
            // 
            // lbl_KOKategori
            // 
            this.lbl_KOKategori.AutoSize = true;
            this.lbl_KOKategori.Location = new System.Drawing.Point(24, 174);
            this.lbl_KOKategori.Name = "lbl_KOKategori";
            this.lbl_KOKategori.Size = new System.Drawing.Size(90, 13);
            this.lbl_KOKategori.TabIndex = 14;
            this.lbl_KOKategori.Text = "Kelime Kategorisi ";
            // 
            // lbl_KOSozcukTuru
            // 
            this.lbl_KOSozcukTuru.AutoSize = true;
            this.lbl_KOSozcukTuru.Location = new System.Drawing.Point(24, 142);
            this.lbl_KOSozcukTuru.Name = "lbl_KOSozcukTuru";
            this.lbl_KOSozcukTuru.Size = new System.Drawing.Size(120, 13);
            this.lbl_KOSozcukTuru.TabIndex = 12;
            this.lbl_KOSozcukTuru.Text = "Cümledeki Sözcük Türü";
            // 
            // lbl_KOTurkceCumle
            // 
            this.lbl_KOTurkceCumle.AutoSize = true;
            this.lbl_KOTurkceCumle.Location = new System.Drawing.Point(24, 111);
            this.lbl_KOTurkceCumle.Name = "lbl_KOTurkceCumle";
            this.lbl_KOTurkceCumle.Size = new System.Drawing.Size(116, 13);
            this.lbl_KOTurkceCumle.TabIndex = 11;
            this.lbl_KOTurkceCumle.Text = "Türkçe Karşılık Cümlesi";
            // 
            // lbl_KOİngilizceCumle
            // 
            this.lbl_KOİngilizceCumle.AutoSize = true;
            this.lbl_KOİngilizceCumle.Location = new System.Drawing.Point(24, 79);
            this.lbl_KOİngilizceCumle.Name = "lbl_KOİngilizceCumle";
            this.lbl_KOİngilizceCumle.Size = new System.Drawing.Size(77, 13);
            this.lbl_KOİngilizceCumle.TabIndex = 10;
            this.lbl_KOİngilizceCumle.Text = "İngilizce Cümle";
            // 
            // lbl_KOTurkce
            // 
            this.lbl_KOTurkce.AutoSize = true;
            this.lbl_KOTurkce.Location = new System.Drawing.Point(22, 52);
            this.lbl_KOTurkce.Name = "lbl_KOTurkce";
            this.lbl_KOTurkce.Size = new System.Drawing.Size(79, 13);
            this.lbl_KOTurkce.TabIndex = 9;
            this.lbl_KOTurkce.Text = "Türkçe Karşılığı";
            // 
            // lbl_KOİngilizce
            // 
            this.lbl_KOİngilizce.AutoSize = true;
            this.lbl_KOİngilizce.Location = new System.Drawing.Point(22, 22);
            this.lbl_KOİngilizce.Name = "lbl_KOİngilizce";
            this.lbl_KOİngilizce.Size = new System.Drawing.Size(79, 13);
            this.lbl_KOİngilizce.TabIndex = 8;
            this.lbl_KOİngilizce.Text = "İngilizce Kelime";
            // 
            // frm_KelimeOgren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 265);
            this.Controls.Add(this.lbl_KOKategori);
            this.Controls.Add(this.lbl_KOSozcukTuru);
            this.Controls.Add(this.lbl_KOTurkceCumle);
            this.Controls.Add(this.lbl_KOİngilizceCumle);
            this.Controls.Add(this.lbl_KOTurkce);
            this.Controls.Add(this.lbl_KOİngilizce);
            this.Controls.Add(this.lbl_GKategori);
            this.Controls.Add(this.lbl_GSozcukTuru);
            this.Controls.Add(this.lbl_GTurkceC);
            this.Controls.Add(this.lbl_GİngilizceC);
            this.Controls.Add(this.lbl_GTurkce);
            this.Controls.Add(this.btn_Ogren);
            this.Controls.Add(this.lbl_Gİngilizce);
            this.Name = "frm_KelimeOgren";
            this.Text = "frm_KelimeOgren";
            this.Load += new System.EventHandler(this.frm_KelimeOgren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Gİngilizce;
        private System.Windows.Forms.Button btn_Ogren;
        private System.Windows.Forms.Label lbl_GTurkce;
        private System.Windows.Forms.Label lbl_GİngilizceC;
        private System.Windows.Forms.Label lbl_GTurkceC;
        private System.Windows.Forms.Label lbl_GSozcukTuru;
        private System.Windows.Forms.Label lbl_GKategori;
        private System.Windows.Forms.Label lbl_KOKategori;
        private System.Windows.Forms.Label lbl_KOSozcukTuru;
        private System.Windows.Forms.Label lbl_KOTurkceCumle;
        private System.Windows.Forms.Label lbl_KOİngilizceCumle;
        private System.Windows.Forms.Label lbl_KOTurkce;
        private System.Windows.Forms.Label lbl_KOİngilizce;
    }
}