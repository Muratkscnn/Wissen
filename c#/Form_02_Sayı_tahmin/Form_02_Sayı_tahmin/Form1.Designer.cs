
namespace Form_02_Sayı_tahmin
{
    partial class Form1
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
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblTahmin = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnSayıGir = new System.Windows.Forms.Button();
            this.lblKalanCan = new System.Windows.Forms.Label();
            this.lblCan = new System.Windows.Forms.Label();
            this.lblHile = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(16, 221);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(428, 56);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Oyuna  Başla";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblTahmin
            // 
            this.lblTahmin.AutoSize = true;
            this.lblTahmin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTahmin.Location = new System.Drawing.Point(12, 123);
            this.lblTahmin.Name = "lblTahmin";
            this.lblTahmin.Size = new System.Drawing.Size(132, 23);
            this.lblTahmin.TabIndex = 1;
            this.lblTahmin.Text = "Tahmin Yapınız:";
            this.lblTahmin.Visible = false;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(150, 126);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(111, 20);
            this.txtTahmin.TabIndex = 2;
            this.txtTahmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTahmin.Visible = false;
            this.txtTahmin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTahmin_KeyDown);
            this.txtTahmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahmin_KeyPress);
            // 
            // btnSayıGir
            // 
            this.btnSayıGir.Location = new System.Drawing.Point(309, 91);
            this.btnSayıGir.Name = "btnSayıGir";
            this.btnSayıGir.Size = new System.Drawing.Size(126, 90);
            this.btnSayıGir.TabIndex = 3;
            this.btnSayıGir.Text = "Tahmin Yap";
            this.btnSayıGir.UseVisualStyleBackColor = true;
            this.btnSayıGir.Visible = false;
            this.btnSayıGir.Click += new System.EventHandler(this.btnSayıGir_Click);
            // 
            // lblKalanCan
            // 
            this.lblKalanCan.AutoSize = true;
            this.lblKalanCan.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalanCan.Location = new System.Drawing.Point(161, 9);
            this.lblKalanCan.Name = "lblKalanCan";
            this.lblKalanCan.Size = new System.Drawing.Size(86, 23);
            this.lblKalanCan.TabIndex = 4;
            this.lblKalanCan.Text = "Kalan Can";
            this.lblKalanCan.Visible = false;
            // 
            // lblCan
            // 
            this.lblCan.AutoSize = true;
            this.lblCan.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCan.Location = new System.Drawing.Point(169, 33);
            this.lblCan.Name = "lblCan";
            this.lblCan.Size = new System.Drawing.Size(65, 78);
            this.lblCan.TabIndex = 5;
            this.lblCan.Text = "5";
            this.lblCan.Visible = false;
            // 
            // lblHile
            // 
            this.lblHile.AutoSize = true;
            this.lblHile.Location = new System.Drawing.Point(406, 9);
            this.lblHile.Name = "lblHile";
            this.lblHile.Size = new System.Drawing.Size(0, 13);
            this.lblHile.TabIndex = 6;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(150, 167);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 319);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblHile);
            this.Controls.Add(this.lblCan);
            this.Controls.Add(this.lblKalanCan);
            this.Controls.Add(this.btnSayıGir);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblTahmin);
            this.Controls.Add(this.btnBaslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Label lblTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnSayıGir;
        private System.Windows.Forms.Label lblKalanCan;
        private System.Windows.Forms.Label lblCan;
        private System.Windows.Forms.Label lblHile;
        private System.Windows.Forms.Label lblSonuc;
    }
}

