namespace VeriTabanlıSecimUgulamasi
{
    partial class FrmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIlce = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnOyGiris = new System.Windows.Forms.Button();
            this.BtnGrafik = new System.Windows.Forms.Button();
            this.BtnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İLÇE ADİ :";
            // 
            // TxtIlce
            // 
            this.TxtIlce.Location = new System.Drawing.Point(129, 27);
            this.TxtIlce.Name = "TxtIlce";
            this.TxtIlce.Size = new System.Drawing.Size(145, 26);
            this.TxtIlce.TabIndex = 1;
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(128, 92);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(145, 26);
            this.TxtA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "A PARTİ :";
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(128, 126);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(145, 26);
            this.TxtB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "B PARTİ :";
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(128, 159);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(145, 26);
            this.TxtC.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "C PARTİ :";
            // 
            // TxtD
            // 
            this.TxtD.Location = new System.Drawing.Point(128, 193);
            this.TxtD.Name = "TxtD";
            this.TxtD.Size = new System.Drawing.Size(145, 26);
            this.TxtD.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "D PARTİ :";
            // 
            // TxtE
            // 
            this.TxtE.Location = new System.Drawing.Point(128, 226);
            this.TxtE.Name = "TxtE";
            this.TxtE.Size = new System.Drawing.Size(145, 26);
            this.TxtE.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "E PARTİ :";
            // 
            // BtnOyGiris
            // 
            this.BtnOyGiris.Location = new System.Drawing.Point(55, 258);
            this.BtnOyGiris.Name = "BtnOyGiris";
            this.BtnOyGiris.Size = new System.Drawing.Size(219, 36);
            this.BtnOyGiris.TabIndex = 12;
            this.BtnOyGiris.Text = "OY GİRİŞİNİ YAP";
            this.BtnOyGiris.UseVisualStyleBackColor = true;
            this.BtnOyGiris.Click += new System.EventHandler(this.BtnOyGiris_Click);
            // 
            // BtnGrafik
            // 
            this.BtnGrafik.Location = new System.Drawing.Point(12, 300);
            this.BtnGrafik.Name = "BtnGrafik";
            this.BtnGrafik.Size = new System.Drawing.Size(151, 36);
            this.BtnGrafik.TabIndex = 14;
            this.BtnGrafik.Text = "GRAFİKLER";
            this.BtnGrafik.UseVisualStyleBackColor = true;
            this.BtnGrafik.Click += new System.EventHandler(this.BtnGrafik_Click);
            // 
            // BtnCikis
            // 
            this.BtnCikis.Location = new System.Drawing.Point(169, 300);
            this.BtnCikis.Name = "BtnCikis";
            this.BtnCikis.Size = new System.Drawing.Size(146, 36);
            this.BtnCikis.TabIndex = 13;
            this.BtnCikis.Text = "ÇIKIŞ YAP";
            this.BtnCikis.UseVisualStyleBackColor = true;
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 352);
            this.Controls.Add(this.BtnGrafik);
            this.Controls.Add(this.BtnCikis);
            this.Controls.Add(this.BtnOyGiris);
            this.Controls.Add(this.TxtE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIlce);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIlce;
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnOyGiris;
        private System.Windows.Forms.Button BtnGrafik;
        private System.Windows.Forms.Button BtnCikis;
    }
}

