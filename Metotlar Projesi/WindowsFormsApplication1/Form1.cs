using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int şifre;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            şifre = Convert.ToInt16(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Sayısal Değer giriniz!!");                
            }
           
                  
            if (textBox1.Text == "Mert" && şifre == 123) 
            {
                MessageBox.Show("Girişiniz Yapıldı");
                Form2 gec = new Form2();
                this.Hide();
                gec.Show();
            }
            else
            {
                button2.Visible = true;
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış");
            }
                

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label3.Text = "Kullanıcı adı = Mert\nŞifre = 123";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            label3.Visible = false;
        }
    }
}
