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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CZzW6_hR068");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
