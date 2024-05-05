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

    public partial class robotEkranı : Form
    {

        
        
        SqlConnection baglanti = new SqlConnection("Data Source=SEYITPC;Initial Catalog=DbRobot;Integrated Security=True;");

        
        
        private int robotX, robotY;
        private string robotYon;
        private int hareketSira;
        

        private void DonusYap(int derece)
        {
           
            if (derece == -90)
                robotYon = YonDondur(robotYon, false);
            else if (derece == 90)
                robotYon = YonDondur(robotYon, true);
        }

        private void HareketEt()
        {
            
            switch (robotYon)
            {
                case "Kuzey":
                    robotY++;
                    break;
                case "Güney":
                    robotY--;
                    break;
                case "Doğu":
                    robotX++;
                    break;
                case "Batı":
                    robotX--;
                    break;
            }
        }
        private string YonDondur(string mevcutYon, bool sagaDon)
        {
            string[] yonler = { "Kuzey", "Doğu", "Güney", "Batı" };
            int mevcutIndex = Array.IndexOf(yonler, mevcutYon);

            if (sagaDon)
                mevcutIndex = (mevcutIndex + 1) % 4;
            else
                mevcutIndex = (mevcutIndex + 3) % 4;

            return yonler[mevcutIndex];
        }
        private void KayitEkle(int hareketSira)
        {
            
            try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=SEYITPC;Initial Catalog=DbRobot;Integrated Security=True;");
                baglanti.Open();

                string query = "INSERT INTO TableRobot (HareketSira, X, Y, Yon) VALUES (@HareketSira, @X, @Y, @Yon)";
                SqlCommand komut2 = new SqlCommand(query, baglanti);

                komut2.Parameters.AddWithValue("@HareketSira", hareketSira);
                komut2.Parameters.AddWithValue("@X", robotX);
                komut2.Parameters.AddWithValue("@Y", robotY);
                komut2.Parameters.AddWithValue("@Yon", robotYon);

                komut2.ExecuteNonQuery();

                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına kayıt eklenirken hata oluştu: " + ex.Message);
            }
        }
        public robotEkranı()
        {
            InitializeComponent();
        }

        

        


        private void bunifuButtonHareket_Click(object sender, EventArgs e)
        {
            
            string query = "DELETE FROM [DbRobot].[dbo].[TableRobot] ";
            new SqlCommand(query, baglanti);

            try
            {
                string komutlar = bunifuTextBoxKomut.Text.ToUpper();

                for (int i = 0; i < komutlar.Length; i++)
                {
                    char komut = komutlar[i];
                    if (komut == 'M')
                    {
                        HareketEt();


                        bunifuDataGridView1.Rows.Add(hareketSira, robotX, robotY, robotYon);


                        KayitEkle(hareketSira);
                        hareketSira++;
                    }
                    else
                    {
                        switch (komut)
                        {
                            case 'L':
                                DonusYap(-90);
                                break;
                            case 'R':
                                DonusYap(90);
                                break;
                            case 'M':
                                HareketEt();
                                break;
                            default:
                                MessageBox.Show("Geçersiz komut!");
                                break;
                        }
                    }

                }
            } catch 
                {
                MessageBox.Show("bir sorun oluştuu");
                }

            LabelSonuc.Text=("HareketSayısı="+(hareketSira=hareketSira-1)+" || "+ "X="+ robotX+" || "+ "Y="+robotY+" || "+"Yön="+ robotYon);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            calisanGiris frm2 = new calisanGiris();
            frm2.ShowDialog();
            this.Close();
        }

        private void bunifuButtonKonumlandir_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [DbRobot].[dbo].[TableRobot] ";
            SqlCommand command = new SqlCommand(query, baglanti);


            try
            {
                if (int.TryParse(bunifuTextBoxXEkseni.Text, out robotX) && int.TryParse(bunifuTextBoxYEkseni.Text, out robotY) && comboBoxYon.SelectedIndex!=-1)
                {
                    robotYon = comboBoxYon.SelectedItem.ToString();
                    hareketSira = 1;
                    MessageBox.Show("Robot konumlandırıldı!");
                }


                else
                {
                    MessageBox.Show("Geçersiz konum değerleri!");
                }
            }
            catch
            {
                MessageBox.Show("bir sorun oluştu");
            }
        }
    }
}
