
namespace OOP_01
{
    partial class polimorphism2
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
            this.btnTekstil = new System.Windows.Forms.Button();
            this.btnTelefon = new System.Windows.Forms.Button();
            this.btnEkmek = new System.Windows.Forms.Button();
            this.dgvsepet = new System.Windows.Forms.DataGridView();
            this.urunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvlifiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsepet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTekstil
            // 
            this.btnTekstil.Location = new System.Drawing.Point(402, 55);
            this.btnTekstil.Name = "btnTekstil";
            this.btnTekstil.Size = new System.Drawing.Size(99, 23);
            this.btnTekstil.TabIndex = 0;
            this.btnTekstil.Text = "Tekstil";
            this.btnTekstil.UseVisualStyleBackColor = true;
            this.btnTekstil.Click += new System.EventHandler(this.B_Click);
            // 
            // btnTelefon
            // 
            this.btnTelefon.Location = new System.Drawing.Point(402, 98);
            this.btnTelefon.Name = "btnTelefon";
            this.btnTelefon.Size = new System.Drawing.Size(99, 23);
            this.btnTelefon.TabIndex = 0;
            this.btnTelefon.Text = "Cep Telefonu";
            this.btnTelefon.UseVisualStyleBackColor = true;
            this.btnTelefon.Click += new System.EventHandler(this.btnTelefon_Click);
            // 
            // btnEkmek
            // 
            this.btnEkmek.Location = new System.Drawing.Point(402, 141);
            this.btnEkmek.Name = "btnEkmek";
            this.btnEkmek.Size = new System.Drawing.Size(99, 23);
            this.btnEkmek.TabIndex = 0;
            this.btnEkmek.Text = "Ekmek";
            this.btnEkmek.UseVisualStyleBackColor = true;
            this.btnEkmek.Click += new System.EventHandler(this.btnEkmek_Click);
            // 
            // dgvsepet
            // 
            this.dgvsepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunAd,
            this.fiyat,
            this.kdvlifiyat});
            this.dgvsepet.Location = new System.Drawing.Point(13, 13);
            this.dgvsepet.Name = "dgvsepet";
            this.dgvsepet.Size = new System.Drawing.Size(343, 208);
            this.dgvsepet.TabIndex = 1;
            // 
            // urunAd
            // 
            this.urunAd.HeaderText = "Ürün Ad";
            this.urunAd.Name = "urunAd";
            // 
            // fiyat
            // 
            this.fiyat.HeaderText = "Fiyat";
            this.fiyat.Name = "fiyat";
            // 
            // kdvlifiyat
            // 
            this.kdvlifiyat.HeaderText = "KDV Dahil Fiyat";
            this.kdvlifiyat.Name = "kdvlifiyat";
            // 
            // polimorphism2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 229);
            this.Controls.Add(this.dgvsepet);
            this.Controls.Add(this.btnEkmek);
            this.Controls.Add(this.btnTelefon);
            this.Controls.Add(this.btnTekstil);
            this.Name = "polimorphism2";
            this.Text = "polimorphism2";
            this.Load += new System.EventHandler(this.polimorphism2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTekstil;
        private System.Windows.Forms.Button btnTelefon;
        private System.Windows.Forms.Button btnEkmek;
        private System.Windows.Forms.DataGridView dgvsepet;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvlifiyat;
    }
}