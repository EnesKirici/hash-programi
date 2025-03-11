
namespace WindowsFormsApp1
{
    partial class ŞifreOluşturma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ŞifreOluşturma));
            this.label1 = new System.Windows.Forms.Label();
            this.xx = new System.Windows.Forms.Label();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHashlenmisSifre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOnerilenSifre = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstHashliSifreler = new System.Windows.Forms.ListBox();
            this.lstOnerilenSifreler = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(280, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre Oluşturma Sayfası";
            // 
            // xx
            // 
            this.xx.BackColor = System.Drawing.Color.Transparent;
            this.xx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.xx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xx.ForeColor = System.Drawing.Color.Silver;
            this.xx.Location = new System.Drawing.Point(21, 128);
            this.xx.Name = "xx";
            this.xx.Size = new System.Drawing.Size(122, 25);
            this.xx.TabIndex = 1;
            this.xx.Text = "Şifrenizi Girin:";
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.BackColor = System.Drawing.Color.Silver;
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.Location = new System.Drawing.Point(149, 131);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(211, 22);
            this.txtKullaniciSifre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(149, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Şifreyi Hashle ve Öneri Yap";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(484, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hashlenmiş Şifre:";
            // 
            // txtHashlenmisSifre
            // 
            this.txtHashlenmisSifre.BackColor = System.Drawing.Color.Silver;
            this.txtHashlenmisSifre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHashlenmisSifre.Location = new System.Drawing.Point(484, 97);
            this.txtHashlenmisSifre.Name = "txtHashlenmisSifre";
            this.txtHashlenmisSifre.ReadOnly = true;
            this.txtHashlenmisSifre.Size = new System.Drawing.Size(228, 22);
            this.txtHashlenmisSifre.TabIndex = 2;
            this.txtHashlenmisSifre.TextChanged += new System.EventHandler(this.txtHashlenmisSifre_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(484, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Önerilen Güçlü Şifre:";
            // 
            // txtOnerilenSifre
            // 
            this.txtOnerilenSifre.BackColor = System.Drawing.Color.Silver;
            this.txtOnerilenSifre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOnerilenSifre.Location = new System.Drawing.Point(484, 169);
            this.txtOnerilenSifre.Name = "txtOnerilenSifre";
            this.txtOnerilenSifre.ReadOnly = true;
            this.txtOnerilenSifre.Size = new System.Drawing.Size(228, 22);
            this.txtOnerilenSifre.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(366, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(112, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(-5, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(793, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dipnot: Bu Hashleme de 16lık Şifreleme Metodu Kullanılmıştır Ve Çakışma Yaşama Ol" +
    "asılığı Daha Fazladır. Bilgilerinize Sunarız.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-2, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(292, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(491, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "//Oluşturduğunuz Şifreyi Ana Sayfadaki \"Hash Şifre Kontrol\" Kısmından Kontrol Ede" +
    "bilirsiniz.";
            // 
            // lstHashliSifreler
            // 
            this.lstHashliSifreler.BackColor = System.Drawing.Color.Silver;
            this.lstHashliSifreler.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstHashliSifreler.FormattingEnabled = true;
            this.lstHashliSifreler.Location = new System.Drawing.Point(405, 239);
            this.lstHashliSifreler.Name = "lstHashliSifreler";
            this.lstHashliSifreler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstHashliSifreler.Size = new System.Drawing.Size(109, 147);
            this.lstHashliSifreler.TabIndex = 13;
            this.lstHashliSifreler.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstOnerilenSifreler
            // 
            this.lstOnerilenSifreler.BackColor = System.Drawing.Color.Silver;
            this.lstOnerilenSifreler.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstOnerilenSifreler.FormattingEnabled = true;
            this.lstOnerilenSifreler.Location = new System.Drawing.Point(661, 239);
            this.lstOnerilenSifreler.Name = "lstOnerilenSifreler";
            this.lstOnerilenSifreler.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstOnerilenSifreler.Size = new System.Drawing.Size(101, 147);
            this.lstOnerilenSifreler.TabIndex = 14;
            this.lstOnerilenSifreler.SelectedIndexChanged += new System.EventHandler(this.lstOnerilenSifreler_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(309, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Önerilen Hashli Şifre:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(586, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "Önerilen Şifreler;";
            // 
            // ŞifreOluşturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(795, 448);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstOnerilenSifreler);
            this.Controls.Add(this.lstHashliSifreler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtOnerilenSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtHashlenmisSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.xx);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.Name = "ŞifreOluşturma";
            this.Load += new System.EventHandler(this.ŞifreOluşturma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label xx;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHashlenmisSifre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOnerilenSifre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstHashliSifreler;
        private System.Windows.Forms.ListBox lstOnerilenSifreler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}