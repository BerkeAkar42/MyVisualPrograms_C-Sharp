using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//Mail gönderi kodları yazınca bu kütüphane eklendi
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Açılan pencereden dosya seçmemizi sağlayacak
            OpenFileDialog opf = new OpenFileDialog();
            //Açılan pencereye yazı yazdık
            opf.Title = "Gönderilecek Dosyayı Seç";
            opf.ShowDialog();

            //Dizini ekranda gösterecek
            //read only ile seçebiliriz ancak müdahale edemeyiz
            textBox1.Text = opf.FileName.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Maili göndermek için 
                MailMessage ePosta = new MailMessage();
                //Gönderen mail adresini sanki buymuş gibi yaptık.
                ePosta.From = new MailAddress("xxxxxxxxx@gmail.com"); //Kimden

                //Maili kime göndereceğimizi seçtik
                //ePosta.To.Add("xxxxxxxx@xxx.edu.tr"); //Kime
                //ePosta.To.Add("xxxxxxxx@gmail.com"); //Kime
                ePosta.To.Add("xxxxxxxxxxxx@gmail.com"); //Kime

                //Eğer kullanıcı dosya eklediyse bunu da alıp gönderecek.
                if (checkBox1.Checked == true)
                {
                    //eklediğimiz dosyayı aldı.
                    ePosta.Attachments.Add(new Attachment(textBox1.Text));
                }

                ePosta.Subject = textBox2.Text;
                ePosta.Body = richTextBox1.Text;


                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("xxxxx@gmail.com", "********");
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.SendAsync(ePosta, (object)ePosta);

                MessageBox.Show("Mail Başarılı Bir Şekilde Gönderildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
