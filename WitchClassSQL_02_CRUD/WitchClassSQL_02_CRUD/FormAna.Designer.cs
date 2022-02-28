
namespace WitchClassSQL_02_CRUD
{
    partial class FormAna
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
            this.btnHastalar = new System.Windows.Forms.Button();
            this.btnBolumler = new System.Windows.Forms.Button();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHastalar
            // 
            this.btnHastalar.Location = new System.Drawing.Point(103, 25);
            this.btnHastalar.Name = "btnHastalar";
            this.btnHastalar.Size = new System.Drawing.Size(236, 76);
            this.btnHastalar.TabIndex = 2;
            this.btnHastalar.Text = "Hastalar";
            this.btnHastalar.UseVisualStyleBackColor = true;
            this.btnHastalar.Click += new System.EventHandler(this.btnHastalar_Click);
            // 
            // btnBolumler
            // 
            this.btnBolumler.Location = new System.Drawing.Point(103, 107);
            this.btnBolumler.Name = "btnBolumler";
            this.btnBolumler.Size = new System.Drawing.Size(236, 70);
            this.btnBolumler.TabIndex = 3;
            this.btnBolumler.Text = "Bolumler";
            this.btnBolumler.UseVisualStyleBackColor = true;
            this.btnBolumler.Click += new System.EventHandler(this.btnBolumler_Click);
            // 
            // btnRandevu
            // 
            this.btnRandevu.Location = new System.Drawing.Point(103, 183);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(236, 74);
            this.btnRandevu.TabIndex = 4;
            this.btnRandevu.Text = "Randevu";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 284);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.btnBolumler);
            this.Controls.Add(this.btnHastalar);
            this.Name = "FormAna";
            this.Text = "AnaForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAna_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHastalar;
        private System.Windows.Forms.Button btnBolumler;
        private System.Windows.Forms.Button btnRandevu;
    }
}

