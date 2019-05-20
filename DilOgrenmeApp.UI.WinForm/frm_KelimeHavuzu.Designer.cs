namespace DilOgrenmeApp.UI.WinForm
{
    partial class frm_KelimeHavuzu
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
            this.dtgrd_KelimeHavuzu = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_KelimeHavuzu)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrd_KelimeHavuzu
            // 
            this.dtgrd_KelimeHavuzu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrd_KelimeHavuzu.Location = new System.Drawing.Point(4, 2);
            this.dtgrd_KelimeHavuzu.Name = "dtgrd_KelimeHavuzu";
            this.dtgrd_KelimeHavuzu.Size = new System.Drawing.Size(670, 301);
            this.dtgrd_KelimeHavuzu.TabIndex = 0;
            // 
            // frm_KelimeHavuzu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 306);
            this.Controls.Add(this.dtgrd_KelimeHavuzu);
            this.Name = "frm_KelimeHavuzu";
            this.Text = "frm_KelimeHavuzu";
            this.Load += new System.EventHandler(this.frm_KelimeHavuzu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrd_KelimeHavuzu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrd_KelimeHavuzu;
    }
}