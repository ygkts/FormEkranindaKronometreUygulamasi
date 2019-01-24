using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grupCalismasiS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saat = 0, dakika = 0, saniye = 0;
        string sonHal;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            saat = 0;
            dakika = 0;
            saniye = 0;
           
            sonHal = label1.Text;
            listBox1.Items.Add(sonHal);
            label1.Text = "0 : 0 : 0";
            

        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = ((Convert.ToString(saniye) + " : ") + (Convert.ToString(dakika) + " : ") + Convert.ToString(saat));
            if ((saniye == 59))
            {
                saniye = 0;
                dakika = dakika + 1;
                if (dakika == 60)
                {
                    saniye = 0;
                    dakika = 0;
                    saat = saat + 1;
                }
            }
            saniye = saniye + 1;

            
        }
    
    }
}
