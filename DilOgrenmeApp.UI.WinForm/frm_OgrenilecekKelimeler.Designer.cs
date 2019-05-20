namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_OgrenilecekKelimeler
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
            this.dtgrid_OgrenilecekKelimeler = new System.Windows.Forms.DataGridView();
            this.btn_OgrenileceklereEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_OgrenilecekKelimeler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_OgrenilecekKelimeler
            // 
            this.dtgrid_OgrenilecekKelimeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid_OgrenilecekKelimeler.Location = new System.Drawing.Point(2, 1);
            this.dtgrid_OgrenilecekKelimeler.Name = "dtgrid_OgrenilecekKelimeler";
            this.dtgrid_OgrenilecekKelimeler.Size = new System.Drawing.Size(718, 330);
            this.dtgrid_OgrenilecekKelimeler.TabIndex = 1;
            // 
            // btn_OgrenileceklereEkle
            // 
            this.btn_OgrenileceklereEkle.Location = new System.Drawing.Point(12, 337);
            this.btn_OgrenileceklereEkle.Name = "btn_OgrenileceklereEkle";
            this.btn_OgrenileceklereEkle.Size = new System.Drawing.Size(142, 23);
            this.btn_OgrenileceklereEkle.TabIndex = 2;
            this.btn_OgrenileceklereEkle.Text = "Öğreneceklerime Ekle";
            this.btn_OgrenileceklereEkle.UseVisualStyleBackColor = true;
            this.btn_OgrenileceklereEkle.Click += new System.EventHandler(this.btn_OgrenileceklereEkle_Click);
            // 
            // frm_OgrenilecekKelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 362);
            this.Controls.Add(this.btn_OgrenileceklereEkle);
            this.Controls.Add(this.dtgrid_OgrenilecekKelimeler);
            this.Name = "frm_OgrenilecekKelimeler";
            this.Text = "frm_OgrenilecekKelimeler";
            this.Load += new System.EventHandler(this.frm_OgrenilecekKelimeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_OgrenilecekKelimeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid_OgrenilecekKelimeler;
        private System.Windows.Forms.Button btn_OgrenileceklereEkle;
    }
}