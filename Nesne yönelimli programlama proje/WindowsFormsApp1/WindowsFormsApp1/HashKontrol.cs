using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pbGeriDon_Click(object sender, EventArgs e)
        {
            Form1 anaSayfa = new Form1();
            anaSayfa.Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnHashliSifreDonustur_Click(object sender, EventArgs e)
        {
            string girilenSifre = txtSifre.Text;
            // kullanıcının girdiği şifre
            // kullanıcının verdiği hash değeri
            string hashliSifre = txtHash.Text; 

        
            using (SHA256 sha256 = SHA256.Create())
            {
                
                byte[] sifreBytes = Encoding.UTF8.GetBytes(girilenSifre);
                byte[] hashBytes = sha256.ComputeHash(sifreBytes);
                

               //                                                                                        0,16
                string yeniHash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower().Substring(0, 16);
                //                                                                           |
              
                if (yeniHash == hashliSifre.ToLower())
                {
                    MessageBox.Show("Şifre doğru!");
                }
                else
                {
                    MessageBox.Show("Şifre eşleşmiyor, lütfen ilk 16 karakteri girdiğinizden emin olunuz.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
