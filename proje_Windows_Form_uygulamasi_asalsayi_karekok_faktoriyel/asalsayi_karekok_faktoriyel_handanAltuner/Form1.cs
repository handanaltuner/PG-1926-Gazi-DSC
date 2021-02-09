using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asalsayi_karekok_faktoriyel_handanAltuner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            int sayi = Convert.ToInt32(girilenSayi.Text);
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    sayac++;
                    break;
                }
            }
            if (sayac == 0)
            {
                sonuc.Text = "Sayı Asaldır.";
            }
            else
            {
                sonuc.Text = "Sayı Asal Değil";
            }

        }

        private void girilenSayi_TextChanged(object sender, EventArgs e)
        {

            
            
                


        }

        private void sonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void faktoriyel_Click(object sender, EventArgs e)
        {




     
            int sayi = int.Parse(girilenSayi.Text);

            long carpim = 1;

            for (int i = sayi; i >= 1; i--)

            {

                carpim *= i; // carpim = carpim*i;

            }

            sonuc.Text = carpim.ToString();

        }

        private void karekok_Click(object sender, EventArgs e)
        {

            int sayi;
            double a;
            sayi = int.Parse(girilenSayi.Text);
            a = Math.Sqrt(sayi);
            sonuc.Text = a.ToString();




        }
    }
}
