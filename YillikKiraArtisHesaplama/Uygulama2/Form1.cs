using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama2
{
    public partial class Form1: Form
    {
        //Bir ev sahibi yıllar sonra ne kadar kira alacağını hesaplayan bir program istemiştir.
        //Program; aylık kira miktarını, yıllık kira artışını(%) ve kaç yıl için hesaplayacağını Textbox1, Textbox2 ve Textbox3 kontrolünden
        //Alınacaktır. Gerekli veri girişlerini, hesaplamalarını yapan ve sonucu Form1 in başlığında yazdıran C# kodlarını yazınız

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float aylikKira = Convert.ToInt32(textBox1.Text);
            float kiraArtiş = Convert.ToInt32(textBox2.Text);
            float kacYil = Convert.ToInt32(textBox3.Text);

            for (int i = 0; i < kacYil; i++)
            {
                 aylikKira += (aylikKira * kiraArtiş / 100);
            }

            this.Text = aylikKira.ToString();
        }

    }
}
