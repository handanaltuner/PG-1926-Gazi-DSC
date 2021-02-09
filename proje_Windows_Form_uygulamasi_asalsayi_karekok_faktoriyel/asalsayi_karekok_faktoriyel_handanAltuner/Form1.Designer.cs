
namespace asalsayi_karekok_faktoriyel_handanAltuner
{
    partial class Form1
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
            this.asalSayi = new System.Windows.Forms.Button();
            this.karekok = new System.Windows.Forms.Button();
            this.faktoriyel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.girilenSayi = new System.Windows.Forms.TextBox();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // asalSayi
            // 
            this.asalSayi.Location = new System.Drawing.Point(391, 130);
            this.asalSayi.Name = "asalSayi";
            this.asalSayi.Size = new System.Drawing.Size(128, 23);
            this.asalSayi.TabIndex = 0;
            this.asalSayi.Text = "Asal sayı";
            this.asalSayi.UseVisualStyleBackColor = true;
            this.asalSayi.Click += new System.EventHandler(this.button1_Click);
            // 
            // karekok
            // 
            this.karekok.Location = new System.Drawing.Point(391, 179);
            this.karekok.Name = "karekok";
            this.karekok.Size = new System.Drawing.Size(128, 23);
            this.karekok.TabIndex = 1;
            this.karekok.Text = "Karekök";
            this.karekok.UseVisualStyleBackColor = true;
            this.karekok.Click += new System.EventHandler(this.karekok_Click);
            // 
            // faktoriyel
            // 
            this.faktoriyel.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.faktoriyel.Location = new System.Drawing.Point(391, 232);
            this.faktoriyel.Name = "faktoriyel";
            this.faktoriyel.Size = new System.Drawing.Size(128, 23);
            this.faktoriyel.TabIndex = 2;
            this.faktoriyel.Text = "Faktöriyel";
            this.faktoriyel.UseVisualStyleBackColor = true;
            this.faktoriyel.Click += new System.EventHandler(this.faktoriyel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bir sayı giriniz : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sonuç : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // girilenSayi
            // 
            this.girilenSayi.Location = new System.Drawing.Point(391, 79);
            this.girilenSayi.Name = "girilenSayi";
            this.girilenSayi.Size = new System.Drawing.Size(128, 22);
            this.girilenSayi.TabIndex = 5;
            this.girilenSayi.TextChanged += new System.EventHandler(this.girilenSayi_TextChanged);
            // 
            // sonuc
            // 
            this.sonuc.Location = new System.Drawing.Point(391, 286);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(128, 22);
            this.sonuc.TabIndex = 6;
            this.sonuc.TextChanged += new System.EventHandler(this.sonuc_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.girilenSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.faktoriyel);
            this.Controls.Add(this.karekok);
            this.Controls.Add(this.asalSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button asalSayi;
        private System.Windows.Forms.Button karekok;
        private System.Windows.Forms.Button faktoriyel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox girilenSayi;
        private System.Windows.Forms.TextBox sonuc;
    }
}

