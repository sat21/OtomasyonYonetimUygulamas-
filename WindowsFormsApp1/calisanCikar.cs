using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class calisanCikar : Form
    {

        SqlConnection baglanti = new SqlConnection("Data Source=SEYITPC;Initial Catalog=DbRobot;Integrated Security=True;");
        
        

        DataTable yenile()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from TableCalisan",baglanti);
            DataTable tablo = new DataTable();
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }

       

        private void ara()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from TableCalisan where Tc like '%" + bunifuTextBoxCalisanTc.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            bunifuDataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        

        public calisanCikar()
        {
            InitializeComponent();
        }

       

        private void bunifuButtonAra_Click(object sender, EventArgs e)
        {
            try {
                int hata = 0;
                if (bunifuTextBoxCalisanTc.Text == string.Empty)
                {
                    hata = 1;
                }
                if (hata == 1)
                {
                    MessageBox.Show("bir kullanıcı girin", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    ara();

                }
            }
            catch
            {
                MessageBox.Show("bir sorun oluştu");
            }
        }

        private void bunifuButtonCalisanCikar_Click(object sender, EventArgs e)
        {
            try
            {
                if(bunifuDataGridView1.SelectedRows==null)
                {
                    MessageBox.Show("veri tabanından silme işlemi sırasında bir hata oldu:\n");
                }
                for (int i = 0; i < bunifuDataGridView1.SelectedRows.Count; i++)
                {
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand("DELETE from TableCalisan where Tc='" + bunifuDataGridView1.SelectedRows[i].Cells[0].Value.ToString() + "'", baglanti);
                    komut2.ExecuteNonQuery();
                    baglanti.Close();
                    
                }

                bunifuDataGridView1.DataSource = yenile();
                MessageBox.Show(bunifuTextBoxCalisanTc.Text + " çıkarıldı");
            }
            catch(Exception )
            {
                MessageBox.Show("veri tabanından silme işlemi sırasında bir hata oldu:\n");
            }

        }

        private void bunifuButtonTumu_Click_1(object sender, EventArgs e)
        {
            bunifuDataGridView1.DataSource = yenile();
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
