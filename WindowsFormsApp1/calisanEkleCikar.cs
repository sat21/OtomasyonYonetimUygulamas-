using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class calisanEkleCikar : Form
    {
        public calisanEkleCikar()
        {
            InitializeComponent();
        }

        private void bunifuThinButtonCalisanCikar_Click(object sender, EventArgs e)
        {
            this.Hide();
            calisanCikar frm2 = new calisanCikar();
            frm2.ShowDialog();
            this.Close();
        }

        private void bunifuThinButtonCalisanEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            calisanEkle frm2 = new calisanEkle();
            frm2.ShowDialog();
            this.Close();
        }

        

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            yoneticiGiris frm2 = new yoneticiGiris();
            frm2.ShowDialog();
            this.Close();
        }
    }
}
