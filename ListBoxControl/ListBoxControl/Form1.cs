using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxControl
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Program çalışınca çalışacak kodlar. (?- Emin Değilim)
            //Program çalışınca listeki tüm verileri silip gelecek.
            listBox1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Butona basınca textBox daki metni listBox a getirecek.
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Butona basınca tüm metinleri siler.
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                //List box da diziler gibi çalışır.
                listBox2.Items.Add(listBox1.Items[i].ToString());
            }
            //En sonunda soldaki listeyi temizleyecek.
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //Sonsuz döngülü tuş yaptık. Verileri taşıyan bir tuş.

            if (listBox1.Items.Count>0)
            {
                listBox2.Items.AddRange(listBox1.Items);
                listBox1.Items.Clear();
            }
            else if (listBox2.Items.Count>0)
            {
                listBox1.Items.AddRange(listBox2.Items);
                listBox2.Items.Clear();
            }
        }
    }
}
