using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tcnodogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcno = textBox1.Text;
            int tctoplam = 0;

            if (tcno.Length != 11)
            {
                MessageBox.Show("11 karakter girmelisiniz!", "Uyarı!");
            }
            else if (tcno.Length == 11)
            {
                for (int i = 0; i < tcno.Length - 1; i++)
                {
                    //char ı sayısal bir değere dönüştürürsen asci karakter karşılığını alır.
                    //O yuzden char ı dönüştüreceksek ilk önce string e çevirip ondan sonra dönüştüreceğimiz türe dönüştürmeliyiz.
                    //Char çok önemli, char ı karıştırma.
                    tctoplam = tctoplam + Convert.ToInt32(tcno[i].ToString());
                }
                //Toplam sayı kontrolünü yaptım.
                //MessageBox.Show(tctoplam.ToString());
                
                if (tctoplam.ToString()[1] == tcno[10])
                {
                    MessageBox.Show("TC No doğrudur!", "Uyarı!");
                }
                else
                {
                    MessageBox.Show("Tc No yanlıştır!", "Uyarı!");
                }
                
            }

        }
    }
}
