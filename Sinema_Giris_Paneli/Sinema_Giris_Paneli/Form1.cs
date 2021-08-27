using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Giris_Paneli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            string telno;
            telno = mtbTel.Text;
            ad = txtAd.Text;
            soyad = txtSoyad.Text;

            label5.Visible = true;
            progressBar1.Visible = true;
            timer1.Start();

            listBox1.Items.Add("Kişi Adı: " + ad);
            listBox1.Items.Add("Kişi Soyadı: " + soyad);
            listBox1.Items.Add("Kişi Telefon No: " + telno);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 25;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Kişi Bilgileri Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Visible = false;
                progressBar1.Visible = false;
                progressBar1.Value = 0;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            mtbTel.Text = "";
        }

        private void label13_Click(object sender, EventArgs e)
        {
        }

        private void maviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.CadetBlue;
        }

        private void yeşilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void turuncuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void beyazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void googleChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe");
        }

        private void microsoftEdgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msedge.exe");
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tümKullanıcıBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void fragmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
        private void fragmanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void fragmanToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            YildizlarArasindaF frm5 = new YildizlarArasindaF();
            frm5.Show();
        }

        private void fragmanToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Testere8 frm6 = new Testere8();
            frm6.Show();
        }

        private void fragmanToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Recepİvedik6 frm7 = new Recepİvedik6();
            frm7.Show();
        }

        private void notDefteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void kişiBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kişi bilgileri kayıt yaptırmaya yarar. Kişi bilgilerini girdikten sonra alttaki kutucuğa bilgiler yansır.", "Kişi Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void kişiBilgiBölümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kişi bilgileri girildikten sonra, kişi bilgilerini alıp yazdıran bölümdür. Tüm bilgileri burda görebilirsiniz.", "Kişi Bilgileri Bölümü", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void biletFiyatBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplu ve tekli bilet fiyatlarının listelendiği bölümdür. Toplu bilet alımlarında indirimler uygulanır.", "Bilet Fiyat Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void yiyecekFiyatBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yiyecek fiyatlarını listeler. Müşteriye yemek fiyatlarındaki öncelikli bilgiyi almasını sağlar.", "Yiyecek Fiyat Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gösterimdekiFilmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gösterimdeki filmleri, salon numaraları ve resimlerle listeler. Müşterinin filmleri ve salon numaralarını görüp bilgilenmesi sağlanır.", "Gösterimdeki Filmler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Sinema Giriş Paneli Taha Toklucu tarafından yapılmıştır.", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void notDefteriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void googleChromeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe");
        }

        private void microsoftEdgeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("msedge.exe");
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
