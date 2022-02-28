
namespace Form_01
{
    partial class Form2
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
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.btnTopla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnCikarma = new System.Windows.Forms.Button();
            this.btnBolme = new System.Windows.Forms.Button();
            this.btnCarpma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(67, 47);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(100, 20);
            this.txtSayı1.TabIndex = 0;
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(234, 47);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(100, 20);
            this.txtSayı2.TabIndex = 1;
            // 
            // btnTopla
            // 
            this.btnTopla.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTopla.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTopla.ForeColor = System.Drawing.Color.Maroon;
            this.btnTopla.Location = new System.Drawing.Point(67, 89);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(100, 55);
            this.btnTopla.TabIndex = 2;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = false;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "1. Sayı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Sayı";
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblSonuc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(65, 228);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(269, 71);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "Sonuç";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCikarma
            // 
            this.btnCikarma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCikarma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikarma.ForeColor = System.Drawing.Color.Maroon;
            this.btnCikarma.Location = new System.Drawing.Point(234, 89);
            this.btnCikarma.Name = "btnCikarma";
            this.btnCikarma.Size = new System.Drawing.Size(100, 55);
            this.btnCikarma.TabIndex = 5;
            this.btnCikarma.Text = "Çıkarma";
            this.btnCikarma.UseVisualStyleBackColor = false;
            this.btnCikarma.Click += new System.EventHandler(this.btnCikarma_Click);
            // 
            // btnBolme
            // 
            this.btnBolme.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBolme.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolme.ForeColor = System.Drawing.Color.Maroon;
            this.btnBolme.Location = new System.Drawing.Point(234, 161);
            this.btnBolme.Name = "btnBolme";
            this.btnBolme.Size = new System.Drawing.Size(100, 55);
            this.btnBolme.TabIndex = 6;
            this.btnBolme.Text = "Bölme";
            this.btnBolme.UseVisualStyleBackColor = false;
            this.btnBolme.Click += new System.EventHandler(this.btnBolme_Click);
            // 
            // btnCarpma
            // 
            this.btnCarpma.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCarpma.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCarpma.ForeColor = System.Drawing.Color.Maroon;
            this.btnCarpma.Location = new System.Drawing.Point(67, 161);
            this.btnCarpma.Name = "btnCarpma";
            this.btnCarpma.Size = new System.Drawing.Size(100, 55);
            this.btnCarpma.TabIndex = 7;
            this.btnCarpma.Text = "Çarpma";
            this.btnCarpma.UseVisualStyleBackColor = false;
            this.btnCarpma.Click += new System.EventHandler(this.btnCarpma_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 319);
            this.Controls.Add(this.btnCarpma);
            this.Controls.Add(this.btnBolme);
            this.Controls.Add(this.btnCikarma);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTopla);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Name = "Form2";
            this.Text = "2 Sayıyı Toplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.TextBox txtSayı2;
        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnCikarma;
        private System.Windows.Forms.Button btnBolme;
        private System.Windows.Forms.Button btnCarpma;
    }
}