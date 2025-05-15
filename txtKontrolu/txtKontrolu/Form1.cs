using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //İnput output kütüphanesi ekledik.

namespace txtKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosya = "veriler.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            // İkinci parametre, ture olduğunda dosya yoksa bile dosyayı oluşturuyor. Varsa dosya da güncelleme yapacak.

            //Sınavda silme, ekleme, düzenleme vs soracakmış.
            TextWriter yazici = new StreamWriter(dosya,true);
            yazici.WriteLine(textBox1.Text);
            //İşledik
            yazici.Flush();
            //Dosya açık olduğundan bu adımda kapattık.
            yazici.Close();

            MessageBox.Show("Girilen Metin txt Dosyasına Kaydedildi...");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //richTextBox1.Clear();
            StreamReader okuyucu = new StreamReader(dosya);

            while (true)
            {
                string satir = okuyucu.ReadLine();

                //sonsuz döngüden kurtarma
                if (satir == null)
                {
                    break;
                }

                richTextBox1.Text += satir + "\n";
            }
            //Dosya açık olduğundan bu adımda kapattık.
            okuyucu.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int karaktersayisi = 0;

            for (int i=0; i< richTextBox1.Text.Length; i++)
            {
                karaktersayisi++;
            }

            MessageBox.Show("Karakter Sayınız: " + karaktersayisi);
        }
    }
}
