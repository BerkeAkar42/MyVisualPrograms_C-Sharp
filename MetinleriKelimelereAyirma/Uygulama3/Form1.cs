using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama3
{
    public partial class Form1: Form
    {
        //Yan taraftaki programda textBox1 e girilen cümleyi button1 e basıldığında boşluklar referans alınarak kelimelere
        //bölmekte ve bu bölünen kelimelere bölmekte ve bu bölünen kelimeler listBox1 kontrolüne alt alta yazdırılmaktadır.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ekranayazdir();
        }

        private void ekranayazdir()
        {
            this.Text = "Toplam Kelime Miktarı: " + toplamklm;
        }

        int toplamklm = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            string kelime = " ";
            string metin = textBox1.Text.ToString();
           

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i].ToString() != " ")
                {
                    kelime += metin[i];
                }
                else if (metin[i].ToString() == " ")
                {
                    listBox1.Items.Add(kelime);
                    kelime = " ";
                    toplamklm++;
                }
            }
            listBox1.Items.Add(kelime);
            kelime = " ";
            toplamklm++;

            ekranayazdir();
        }
    }
}
