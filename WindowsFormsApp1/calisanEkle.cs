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
    public partial class calisanEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=SEYITPC;Initial Catalog=DbRobot;Integrated Security=True;");

        public calisanEkle()
        {
            InitializeComponent();
        }
        
       

        private void bunifuButtonCalisanEkle2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string cinsiyet;

                if (bunifuRadioButtonCalisanKadın.Checked == true)
                {
                    cinsiyet = "kadın";
                }
                else
                {
                    cinsiyet = "erkek";
                }

                if (bunifuTextBoxCalisanTc.Text != string.Empty && bunifuTextBoxCalisanTc.Text.Length==11 && bunifuTextBoxCalisanAd.Text != string.Empty && bunifuTextBoxCalisanSoyad.Text != string.Empty && bunifuTextBoxCalisanSicil.Text != string.Empty)
                {

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("Insert into TableCalisan (Tc,Ad,Soyad,Sifre,Cİnsiyet) Values ('" + bunifuTextBoxCalisanTc.Text.ToString() + "','" + bunifuTextBoxCalisanAd.Text.ToString() + "','" + bunifuTextBoxCalisanSoyad.Text.ToString() + "','" + bunifuTextBoxCalisanSicil.Text.ToString() + "','" + cinsiyet.ToString() + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show(bunifuTextBoxCalisanAd.Text + " eklendi");
                }
                else
                {
                    if(bunifuTextBoxCalisanTc.Text.Length != 11)
                    {
                        MessageBox.Show("Tc No 11 haneli olmalı");
                    }
                    else
                    {
                        MessageBox.Show("Tüm alanları doldurunuz");
                    }
                    
                }
            }
            catch {

                MessageBox.Show("bir hata oldu");
            }
        }

        

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            calisanEkleCikar frm2 = new calisanEkleCikar();
            frm2.ShowDialog();
            this.Close();
        }
    }
}
