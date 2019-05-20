namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_OgrendigimKelimeler
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
            this.grdviev_OgrendigimKelimeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdviev_OgrendigimKelimeler)).BeginInit();
            this.SuspendLayout();
            // 
            // grdviev_OgrendigimKelimeler
            // 
            this.grdviev_OgrendigimKelimeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdviev_OgrendigimKelimeler.Location = new System.Drawing.Point(1, 1);
            this.grdviev_OgrendigimKelimeler.Name = "grdviev_OgrendigimKelimeler";
            this.grdviev_OgrendigimKelimeler.Size = new System.Drawing.Size(704, 386);
            this.grdviev_OgrendigimKelimeler.TabIndex = 0;
            // 
            // frm_OgrendigimKelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 388);
            this.Controls.Add(this.grdviev_OgrendigimKelimeler);
            this.Name = "frm_OgrendigimKelimeler";
            this.Text = "frm_OgrendigimKelimeler";
            this.Load += new System.EventHandler(this.frm_OgrendigimKelimeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdviev_OgrendigimKelimeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdviev_OgrendigimKelimeler;
    }
}