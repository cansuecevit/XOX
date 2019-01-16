using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımSınamaXOX
{
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }


        string ad="";
        public void temizle()
        {
            foreach (Button btn in this.Controls)
            {
                btn.Text = "";
                btn.ForeColor = Color.Black;
                btnGeriDönOyun.Text = "Geri Dön";
            }
            harf = "X";
        }
        string harf = "X";
        public void XOXoyunu(Button btn)
        {
            if (harf == "X" && btn.Text == "")
            {
                ad = XOX.oyuncu1.ad;
                btn.Text = harf;
                harf = "O";
            }
            else if (harf == "O" && btn.Text == "")
            {
                ad = XOX.oyuncu2.ad;
                btn.Text = harf;
                harf = "X";
            }
        }

        public void kontrol()
        {
            if ((btn1.Text != "" && btn2.Text != "" & btn3.Text != "") && (btn1.Text == btn2.Text && btn2.Text == btn3.Text))
            {

                btn1.ForeColor = Color.Red;
                btn2.ForeColor = Color.Red;
                btn3.ForeColor = Color.Red;
                MessageBox.Show("Oyun Bitti Kazanan:  "+ad);
                temizle();
            }
            else if ((btn4.Text != "" && btn5.Text != "" & btn6.Text != "") && (btn4.Text == btn5.Text && btn5.Text == btn6.Text))
            {

                btn4.ForeColor = Color.Red;
                btn5.ForeColor = Color.Red;
                btn6.ForeColor = Color.Red;
                MessageBox.Show("Oyun Bitti Kazanan:  " +ad);
                temizle();
            }
            else if ((btn7.Text != "" && btn8.Text != "" & btn9.Text != "") && (btn7.Text == btn8.Text && btn8.Text == btn9.Text))
            {
                btn7.ForeColor = Color.Red;
                btn8.ForeColor = Color.Red;
                btn9.ForeColor = Color.Red;
                MessageBox.Show("Oyun Bitti Kazanan:  " +ad);
                temizle();
            }
            else if ((btn1.Text != "" && btn4.Text != "" & btn7.Text != "") && (btn1.Text == btn4.Text && btn4.Text == btn7.Text))
            {
                btn1.ForeColor = Color.Red;
                btn4.ForeColor = Color.Red;
                btn7.ForeColor = Color.Red;
                MessageBox.Show("Oyun Bitti Kazanan:  " +ad);
                temizle();
            }
            else if ((btn2.Text != "" && btn5.Text != "" & btn8.Text != "") && (btn2.Text == btn5.Text && btn5.Text == btn8.Text))
            {
                btn2.ForeColor = Color.Red;
                btn5.ForeColor = Color.Red;
                btn8.ForeColor = Color.Red;
                MessageBox.Show("Oyun Bitti Kazanan:  " +ad);
                temizle();
            }
            else if ((btn3.Text != "" && btn6.Text != "" & btn9.Text != "") && (btn3.Text == btn6.Text && btn6.Text == btn9.Text))
            {
                btn3.ForeColor = Color.Red;
                btn6.ForeColor = Color.Red;
                btn9.ForeColor = Color.Red;
                MessageBox.Show("Oyun Bitti Kazanan:  " +ad);
                temizle();
            }
            else if ((btn1.Text != "" && btn5.Text != "" & btn9.Text != "") && (btn1.Text == btn5.Text && btn5.Text == btn9.Text))
            {
                btn1.ForeColor = Color.Red;
                btn5.ForeColor = Color.Red;
                btn9.ForeColor = Color.Red;
                MessageBox.Show("Oyun Bitti Kazanan:  " +ad);
                temizle();
            }
            else if ((btn7.Text != "" && btn5.Text != "" & btn3.Text != "") && (btn7.Text == btn5.Text && btn5.Text == btn3.Text))
            {
                btn7.ForeColor = Color.Red;
                btn5.ForeColor = Color.Red;
                btn3.ForeColor = Color.Red;
                MessageBox.Show("Oyun Bitti Kazanan:  " +ad);
                temizle();
            }
            int adet = 0;
            foreach (Button btn in this.Controls)
            {
                if (btn.Text != "")
                {
                    adet++;
                }
            }

            if (adet == 9)
            {
                MessageBox.Show("OYUN BİTTİ KAZANAN YOK");
                temizle();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn1);
            kontrol();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn2);
            kontrol();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn3);
            kontrol();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn4);
            kontrol();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn5);
            kontrol();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn6);
            kontrol();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn7);
            kontrol();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn8);
            kontrol();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            XOXoyunu(btn9);
            kontrol();
        }

        private void btnGeriDönOyun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Geri dönmek istediğinize emin misiniz?", "Geri Dön", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                XOX frm = new XOX();
                frm.Show();
            }

        }
    }
}
