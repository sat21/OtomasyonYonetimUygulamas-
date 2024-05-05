using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class yoneticiGiris : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader oku;


        public yoneticiGiris()
        {
            InitializeComponent();
        }
        
        private void bunifuButtonYoneticiGiris_Click_2(object sender, EventArgs e)
        {
            try
            {
                string kullanici = bunifuTextBoxYoneticiTc.Text;
                string sifre = bunifuTextBoxYoneticiSifre.Text;
                baglanti = new SqlConnection("Data Source=SEYITPC;Initial Catalog=DbRobot;Integrated Security=True;");
                komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM TableYonetici where Tc='" + kullanici + "' AND Sifre='" + sifre + "'";
                oku = komut.ExecuteReader();
                if (oku.Read())
                {

                    this.Hide();
                    calisanEkleCikar frm2 = new calisanEkleCikar();
                    frm2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
                }
                baglanti.Close();
            }
            catch
            {
                MessageBox.Show("bir sorun oluştuu");
            }

        }

        

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            giris frm2 = new giris();
            frm2.ShowDialog();
            this.Close();
        }
    }
}
