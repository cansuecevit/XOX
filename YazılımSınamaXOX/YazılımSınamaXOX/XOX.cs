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
    public partial class XOX : Form
    {

        public XOX()
        {
            InitializeComponent();
        }
        public static OyuncuBilgi oyuncu1 = new OyuncuBilgi();
        public static OyuncuBilgi oyuncu2 = new OyuncuBilgi();

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            oyuncu1.ad = txtoyuncu1.Text;
            oyuncu2.ad = txtoyuncu2.Text;
            if(txtoyuncu1.Text!=""&&txtoyuncu2.Text!="")
            {
                this.Hide();
                Oyun frm = new Oyun();
                frm.Show();
            }
            else
                MessageBox.Show("Lütfen oyuncu 1 ve oyuncu 2 alanlarını doldurunuz!");

        }

        private void btnPc_Click(object sender, EventArgs e)
        {
            oyuncu1.ad = txtoyuncu.Text;
            if(txtoyuncu1.Text == "" && txtoyuncu2.Text == ""&&txtoyuncu.Text!="")
            {
                this.Hide();
                Bilgisayara_Karsi frm = new Bilgisayara_Karsi();
                frm.Show();
            }
            else if(txtoyuncu.Text == "")
                MessageBox.Show("Lütfen oyuncu alanını doldurunuz!");
            else
                MessageBox.Show("Lütfen sadece gerekli alanı doldurunuz!");

        }

        private void btnNasilOynanir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanyana, Çaprazlama, Üstüste 3 Tane \n X veya O getiren taraf kazanır.\n İyi oyunlar.");
        }

 
    }
}
