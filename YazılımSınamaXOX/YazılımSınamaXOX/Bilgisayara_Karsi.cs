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
    public partial class Bilgisayara_Karsi : Form
    {
        public Bilgisayara_Karsi()
        {
            InitializeComponent();
        }
        string ad = "";
        public void temizle()
        {
            foreach (Button btn in this.Controls)
            {
                btn.Text = "";
                btn.ForeColor = Color.Black;
                btnGeriDön.Text= "Geri Dön";
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


        }
        public void BilgisayarOyna()
        {
            Random r = new Random();
            int no = r.Next(1, 10);
            for(int i=1;i<10;i++)
            {
                if (no == 1 && button1.Text == "")
                {
                    button1.Text = harf;
                    break;
                }
                else if (no == 2 && button2.Text == "")
                {
                    button1.Text = harf;
                    break;
                }
                else if (no == 3 && button3.Text == "")
                {
                    button3.Text = harf;
                    break;
                }
                else if (no == 4 && button4.Text == "")
                {
                    button4.Text = harf;
                    break;
                }
                else if (no == 5 && button5.Text == "")
                {
                    button5.Text = harf;
                    break;
                }
                else if (no == 6 && button6.Text == "")
                {
                    button6.Text = harf;
                    break;
                }
                else if (no == 7 && button7.Text == "")
                {
                    button7.Text = harf;
                    break;
                }
                else if (no == 8 && button8.Text == "")
                {
                    button8.Text = harf;
                    break;
                }
                else if (no == 9 && button9.Text == "")
                {
                    button9.Text = harf;
                    break;
                }
                else
                {
                    if (no < 9)
                        no++;
                    else
                        no--;
                }

            }

            harf = "X";

        }
        public void kontrol()
        {
            if ((button1.Text != "" && button2.Text != "" & button3.Text != "") && (button1.Text == button2.Text && button2.Text == button3.Text))
            {

                button1.ForeColor = Color.Red;
                button2.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;
                if(button1.Text=="X")
                MessageBox.Show("Oyun Bitti Kazanan:  " + ad);
                else
                    MessageBox.Show("Oyun Bitti Kazanan:Bilgisayar ");

                temizle();
            }
            else if ((button4.Text != "" && button5.Text != "" & button6.Text != "") && (button4.Text == button5.Text && button5.Text == button6.Text))
            {

                button4.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button6.ForeColor = Color.Red;
                if (button4.Text == "X")
                    MessageBox.Show("Oyun Bitti Kazanan:  " + ad);
                else
                    MessageBox.Show("Oyun Bitti Kazanan:Bilgisayar ");
                temizle();
            }
            else if ((button7.Text != "" && button8.Text != "" & button9.Text != "") && (button7.Text == button8.Text && button8.Text == button9.Text))
            {
                button7.ForeColor = Color.Red;
                button8.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                if (button7.Text == "X")
                    MessageBox.Show("Oyun Bitti Kazanan:  " + ad);
                else
                    MessageBox.Show("Oyun Bitti Kazanan:Bilgisayar ");
                temizle();
            }
            else if ((button1.Text != "" && button4.Text != "" & button7.Text != "") && (button1.Text == button4.Text && button4.Text == button7.Text))
            {
                button1.ForeColor = Color.Red;
                button4.ForeColor = Color.Red;
                button7.ForeColor = Color.Red;
                if (button1.Text == "X")
                    MessageBox.Show("Oyun Bitti Kazanan:  " + ad);
                else
                    MessageBox.Show("Oyun Bitti Kazanan:Bilgisayar ");
                temizle();
            }
            else if ((button2.Text != "" && button5.Text != "" & button8.Text != "") && (button2.Text == button5.Text && button5.Text == button8.Text))
            {
                button2.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button8.ForeColor = Color.Red;
                if (button2.Text == "X")
                    MessageBox.Show("Oyun Bitti Kazanan:  " + ad);
                else
                    MessageBox.Show("Oyun Bitti Kazanan:Bilgisayar ");
                temizle();
            }
            else if ((button3.Text != "" && button6.Text != "" & button9.Text != "") && (button3.Text == button6.Text && button6.Text == button9.Text))
            {
                button3.ForeColor = Color.Red;
                button6.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                if (button3.Text == "X")
                    MessageBox.Show("Oyun Bitti Kazanan:  " + ad);
                else
                    MessageBox.Show("Oyun Bitti Kazanan:Bilgisayar ");
                temizle();
            }
            else if ((button1.Text != "" && button5.Text != "" & button9.Text != "") && (button1.Text == button5.Text && button5.Text == button9.Text))
            {
                button1.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button9.ForeColor = Color.Red;
                if (button1.Text == "X")
                    MessageBox.Show("Oyun Bitti Kazanan:  " + ad);
                else
                    MessageBox.Show("Oyun Bitti Kazanan:Bilgisayar ");
                temizle();
            }
            else if ((button7.Text != "" && button5.Text != "" & button3.Text != "") && (button7.Text == button5.Text && button5.Text == button3.Text))
            {
                button7.ForeColor = Color.Red;
                button5.ForeColor = Color.Red;
                button3.ForeColor = Color.Red;
                if (button7.Text == "X")
                    MessageBox.Show("Oyun Bitti Kazanan:  " + ad);
                else
                    MessageBox.Show("Oyun Bitti Kazanan:Bilgisayar ");
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
        private void button1_Click(object sender, EventArgs e)
        {
            XOXoyunu(button1);
            BilgisayarOyna();
            kontrol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XOXoyunu(button2);
            BilgisayarOyna();
            kontrol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XOXoyunu(button3);
            BilgisayarOyna();
            kontrol();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XOXoyunu(button4);
            BilgisayarOyna();
            kontrol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            XOXoyunu(button5);
            BilgisayarOyna();
            kontrol();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            XOXoyunu(button6);
            BilgisayarOyna();
            kontrol();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            XOXoyunu(button7);
            BilgisayarOyna();
            kontrol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XOXoyunu(button8);
            BilgisayarOyna();
            kontrol();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XOXoyunu(button9);
            BilgisayarOyna();
            kontrol();
        }

        private void btnGeriDön_Click(object sender, EventArgs e)
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

    
