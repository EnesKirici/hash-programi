
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.pbGeriDon = new System.Windows.Forms.PictureBox();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGeriDon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.BackColor = System.Drawing.Color.Black;
            this.btnKontrolEt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKontrolEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontrolEt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrolEt.ForeColor = System.Drawing.Color.Silver;
            this.btnKontrolEt.Location = new System.Drawing.Point(314, 236);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(148, 26);
            this.btnKontrolEt.TabIndex = 0;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = false;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnHashliSifreDonustur_Click);
            // 
            // pbGeriDon
            // 
            this.pbGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGeriDon.Image = ((System.Drawing.Image)(resources.GetObject("pbGeriDon.Image")));
            this.pbGeriDon.Location = new System.Drawing.Point(-1, 12);
            this.pbGeriDon.Name = "pbGeriDon";
            this.pbGeriDon.Size = new System.Drawing.Size(78, 36);
            this.pbGeriDon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGeriDon.TabIndex = 2;
            this.pbGeriDon.TabStop = false;
            this.pbGeriDon.Click += new System.EventHandler(this.pbGeriDon_Click);
            // 
            // txtHash
            // 
            this.txtHash.BackColor = System.Drawing.Color.Silver;
            this.txtHash.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHash.Location = new System.Drawing.Point(314, 210);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(148, 22);
            this.txtHash.TabIndex = 3;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Silver;
            this.txtSifre.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(314, 139);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(148, 22);
            this.txtSifre.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(311, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hashli Şifre;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(311, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.No;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(9, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(793, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dipnot: Bu Hashleme de 16lık Şifreleme Metodu Kullanılmıştır Ve Çakışma Yaşama Ol" +
    "asılığı Daha Fazladır. Bilgilerinize Sunarız.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(486, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dipnot: Farklı Bir Hash Formatı Yazılması Durumunda Sistem Hata Verecektir.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(278, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Hash Kontrol Sayfası";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.pbGeriDon);
            this.Controls.Add(this.btnKontrolEt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGeriDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.PictureBox pbGeriDon;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}