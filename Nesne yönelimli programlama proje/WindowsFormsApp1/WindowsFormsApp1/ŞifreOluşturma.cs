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
    public partial class ŞifreOluşturma : Form
    {
        public ŞifreOluşturma()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtHashlenmisSifre_TextChanged(object sender, EventArgs e)
        {
            {

            }

        }

        private void ŞifreOluşturma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // şifreal
                string sifre = txtKullaniciSifre.Text;

                // hash kısa 
                string hashlenmisSifre = HashleSifre(sifre);
                txtHashlenmisSifre.Text = hashlenmisSifre;  

                string onerilenSifre = SifreOner(sifre);
                txtOnerilenSifre.Text = onerilenSifre; 

                txtHashlenmisSifre.Text = hashlenmisSifre;
                txtOnerilenSifre.Text = onerilenSifre;

               //listbox
                lstHashliSifreler.Items.Add(hashlenmisSifre);
                lstOnerilenSifreler.Items.Add(onerilenSifre);
            }

        }
        public string HashleSifre(string sifre)
        {
            using (SHA256 sha256 = SHA256.Create()) 
            {
                {
                    byte[] sifreBytes = Encoding.UTF8.GetBytes(sifre);
                    byte[] hashBytes = sha256.ComputeHash(sifreBytes);  
                    string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();  
                    return hash.Substring(0, 16); 
                    //         |
                   
                }
            }
        }


        public string SifreOner(string kullaniciSifresi)
        {
            Random rand = new Random();
            StringBuilder sb = new StringBuilder();

            foreach (char c in kullaniciSifresi)
            {
                sb.Append(c);
                if (rand.Next(0, 2) == 0)  
                {
                    sb.Append(rand.Next(0, 10));  
                }
            }

            string karakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*-_[}***";
            sb.Append(karakterler[rand.Next(karakterler.Length)]);  

            return sb.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            {
                Form1 anaSayfa = new Form1();
                anaSayfa.Show();
                this.Close();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHashliSifreler.SelectedItem != null) 
            {
                string selectedPassword = lstHashliSifreler.SelectedItem.ToString();
                Clipboard.SetText(selectedPassword); 
                MessageBox.Show("Şifre kopyalandı: " + selectedPassword); 
            }
            else
            {
                MessageBox.Show("Lütfen bir şifre seçiniz!"); 
            }
        }

        private void lstOnerilenSifreler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOnerilenSifreler != null) 
            {
                if (lstOnerilenSifreler.SelectedItem != null) 
                {
                    string selectedPassword = lstOnerilenSifreler.SelectedItem.ToString(); 
                    Clipboard.SetText(selectedPassword); 
                    MessageBox.Show("Şifre kopyalandı: " + selectedPassword); 
                }
                else
                {
                    MessageBox.Show("Lütfen bir şifre seçiniz!"); 
                }

            }
        }
    }
}
