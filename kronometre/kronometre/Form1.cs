using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int salise = 0;
        int saniye = 0;
        int dakika = 0;
        int saat = 0;

        void ekranayaz()
        {
            //Ekrana her şeyi yazdıracak
            textBox1.Text = saat.ToString();
            textBox2.Text = dakika.ToString();
            textBox3.Text = saniye.ToString();
            textBox4.Text = salise.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kronometre"; 
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //durdur
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (salise<59)
            {
                salise++;
            }
            else
            {
                if (saniye<59)
                {
                    salise = 0;
                    saniye++;
                }
                else
                {
                    if (dakika<59)
                    {
                        dakika = 0;
                        dakika++;
                    }
                    else
                    {
                        saat = 0;
                        saat++;
                    }
                }
            }
                ekranayaz();
        }

        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
