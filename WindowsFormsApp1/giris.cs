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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void bunifuTileButtonYonetici_Click(object sender, EventArgs e)
        {
            this.Hide();
            yoneticiGiris frm2 = new yoneticiGiris();
            frm2.ShowDialog();
            this.Close();
        }

        private void bunifuTileButtonCalisan_Click(object sender, EventArgs e)
        {
            this.Hide();
            calisanGiris frm2 = new calisanGiris();
            frm2.ShowDialog();
            this.Close();
        }

        
    }
}
