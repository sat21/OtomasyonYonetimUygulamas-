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
    public partial class calisanGiris : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;

        public calisanGiris()
        {
            InitializeComponent();
        }


        

        private void bunifuButtonCalisanGiris_Click_1(object sender, EventArgs e)
        {
            try
            {
                string user = bunifuTextBoxCalisanTc.Text;
                string pass = bunifuTextBoxCalisanSifre.Text;
                baglanti = new SqlConnection("Data Source=SEYITPC;Initial Catalog=DbRobot;Integrated Security=True;");
                komut = new SqlCommand();
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT * FROM TableCalisan where Tc='" + bunifuTextBoxCalisanTc.Text + "' AND Sifre='" + bunifuTextBoxCalisanSifre.Text + "'";
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    robotEkranı frm2 = new robotEkranı();
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
                MessageBox.Show("bir sorun oluştu");
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
