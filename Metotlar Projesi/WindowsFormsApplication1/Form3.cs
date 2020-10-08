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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int say;
        private void Button1_Click(object sender, EventArgs e)
        {
            say = 0;
            timer1.Start();       
            timer1.Interval = 1000;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            say++;
            if (say == 3)
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                label1.Visible = true;
                label1.Text = "Metotlar belirli Bir işi gerçekleştirmek \niçin yazılan alt programlara metot denir";
            }
            if (say == 5)
            {
                label2.Visible = true;
                label2.Text = "Metot Kullanılmasının faydaları :\n\n- Kodun okunabilirliği artar.\n- Tekrarlar önlenerek kaynak kodun büyümesi engellenir.\n- Oluşan hataların tespiti ve giderilmesi kolaylaşır.";
            }
            if (say == 8)
            {
                timer1.Stop();
                timer2.Start();
                timer2.Interval = 450;
                pictureBox1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
            }

        }
        int renkSayacı;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            renkSayacı++;
            if (renkSayacı % 2 == 0)
            {
                label3.ForeColor = Color.Red;
            }
            else if (renkSayacı % 2 == 1)
            {
                label3.ForeColor = Color.Gold;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label10.Visible = true;
            label8.Visible = true;
            progressBar1.Visible = true;
            label11.Visible = true;
            button1.Visible = false;
            timer4.Start();
            timer3.Start();
            pictureBox1.Visible = false;
            button4.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 gec = new Form2();
            this.Hide();
            gec.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form5 gec = new Form5();
            this.Hide();
            gec.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form4 gec = new Form4();
            this.Hide();
            gec.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            say++;
            if (say % 9 == 1)
            {
                label10.Text = "Metotlar Yükleniyor.";
            }
            else if (say % 2 == 1)
            {
                label10.Text = "Metotlar Yükleniyor..";
            }
            else if (say % 3 == 0)
            {
                label10.Text = "Metotlar Yükleniyor...";
            }
            if (say == 100)
            {
                timer3.Stop();
                label10.Text = " Metotlar Yüklendi ".ToString();
            }
            if (progressBar1.Value == 25)
            {
                label9.Text = "Konu Anlatımı Hazırlanıyor";
            }
            if (progressBar1.Value == 50)
            {
                label9.Text = "Timerler Hazırlanıyor";
            }
            if (progressBar1.Value == 75)
            {
                label9.Text = "Konu Anlatımı Kontrol Ediliyor";
            }
            if (progressBar1.Value == 99)
            {
                label9.Text = "Konu Anlatımı Hazırlandı\n";
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            label11.Text = "%" + progressBar1.Value.ToString();
            if (progressBar1.Value == 50)
            {
                label11.BackColor = Color.MediumSeaGreen;
            }
            if (progressBar1.Value == 100)
            {              
                timer4.Stop();
                label10.Visible = false;
                label8.Visible = false;
                progressBar1.Visible = false;
                label11.Visible = false;
                button1.Visible = true;
                label9.Visible = false;
                timer3.Stop();
                timer4.Stop();
                MessageBox.Show("Konu Anlatımı Hazırlandı Artık Metotları Öğrenebilirsiniz");
            }
        }
    }
}
    
