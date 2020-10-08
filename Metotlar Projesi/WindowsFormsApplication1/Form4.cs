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
    public partial class Form4 : Form
    {
        int kontrol = 0;
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load_1(object sender, EventArgs e)
        {
            label2.Visible = false;
            pictureBox1.Visible = false;
            label1.Text = "Aşağıdaki metot tanımlamalarından hangisi doğrudur?";
            radioButton1.Text = "A) int hesapla(int a,b)";
            radioButton2.Text = "B) void islem( )";
            radioButton3.Text = "C) int sonuc(int x; double y)";
            radioButton4.Text = "D) void (int x,y, bool a)";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && kontrol == 0)
            {
                radioButton1.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton2.Checked && kontrol == 0)
            {
                kontrol = 1;
                radioButton2.BackColor = Color.Green;
                MessageBox.Show("Doğru");
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                label1.Text = "Metotların aşırı yüklenmesine ne ad verilir?";
                radioButton1.Text = "A) Local Variable";
                radioButton2.Text = "B) Global Variable";
                radioButton3.Text = "C) OverLoad";
                radioButton4.Text = "D) Step Over";
            }
            if (radioButton3.Checked && kontrol == 0)
            {
                radioButton3.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton4.Checked && kontrol == 0)
            {
                radioButton4.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton1.Checked && kontrol == 1)
            {
                radioButton1.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton2.Checked && kontrol == 1)
            {
                radioButton2.BackColor = Color.Red;
                MessageBox.Show("Yanlış");          
            }
            if (radioButton3.Checked && kontrol == 1)
            {
                kontrol = 2;
                radioButton3.BackColor = Color.Green;
                MessageBox.Show("Doğru");
                radioButton3.Checked = false;
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                label1.Text = "Metotlarla ilgili aşağıdakilerden hangisi yanlıştır?";
                radioButton1.Text = "A) Overload işlemi tekrarlı kod satırlarını önleyebilir.";
                radioButton2.Text = "B)	Main metodu içinde sınırsız sayıda metot çağrılabilir.";
                radioButton3.Text = "C)	Metot eğer geriye bir değer döndürmüyorsa return kullanılmayabilir";
                radioButton4.Text = "D)	Metotların geri dönüş türü ayırt edici özelliklerdendir.";           
            }
            if (radioButton4.Checked && kontrol == 1)
            {
                radioButton4.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton1.Checked && kontrol == 2)
            {
                radioButton1.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton2.Checked && kontrol == 2)
            {
                radioButton2.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton3.Checked && kontrol == 2)
            {
                radioButton3.BackColor = Color.Red;
                MessageBox.Show("Yanlış");           
            }
            if (radioButton4.Checked && kontrol == 2)
            {
                kontrol = 3;
                radioButton4.BackColor = Color.Green;
                MessageBox.Show("Doğru");
                radioButton4.Checked = false;
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                label1.Text = "İki tanımlayıcı aynı isme sahipse ve aynı kapsam içinde bildirilirlerse aşağıdakilerden hangisi söylenemez?";
                radioButton1.Text = "A) Parametre sayıları farklı olmalıdır.";
                radioButton2.Text = "B) Parametre türleri farklı olmalıdır.";
                radioButton3.Text = "C) Geri dönüş türü farklı olmalıdır.";
                radioButton4.Text = "D) Overload yapılmış olabilir.";
            }
            if (radioButton1.Checked && kontrol ==32)
            {
                radioButton1.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton2.Checked && kontrol == 3)
            {
                radioButton2.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton3.Checked && kontrol == 3)
            {
                kontrol = 4;
                radioButton3.BackColor = Color.Green;
                MessageBox.Show("Doğru");
                radioButton3.Checked = false;
                radioButton1.BackColor = Color.White;
                radioButton2.BackColor = Color.White;
                radioButton3.BackColor = Color.White;
                radioButton4.BackColor = Color.White;
                label1.Text = "Return ifadesiyle ilgili olarak aşağıdakilerden hangisi yanlıştır?";
                radioButton1.Text = "A) return ifadesinin döndürdüğü veri türü ile metodun döndürdüğü veri türü aynı olmalıdır.";
                radioButton2.Text = "B) return ifadesi metodun sonunda bulunmak zorundadır.";
                radioButton3.Text = "C) return ifadesinden sonra noktalı virgül konulmalıdır.";
                radioButton4.Text = "D) Her metoda return ifadesi bulunmak zorundadır.";
            }
            if (radioButton4.Checked && kontrol == 3)
            {
                radioButton3.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton1.Checked && kontrol == 4)
            {
                radioButton1.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton2.Checked && kontrol == 4)
            {
                radioButton2.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton3.Checked && kontrol == 4)
            {
                radioButton3.BackColor = Color.Red;
                MessageBox.Show("Yanlış");
            }
            if (radioButton4.Checked && kontrol == 4)
            {
                label2.Visible = true;
                timer1.Start();
                timer1.Interval = 300;
                radioButton4.BackColor = Color.Green;
                label1.Visible = false;
                radioButton1.Visible = false;
                radioButton3.Visible = false;
                radioButton2.Visible = false;
                radioButton4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                pictureBox1.Visible = true;
                MessageBox.Show("Tebrikler Cevabınız Doğru \nDoğru/Yanlış Sorularına Yönlendiriliyorsunuz");
                Form7 gec = new Form7();
                this.Hide();
                gec.Show();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form6 gec = new Form6();
            this.Hide();
            gec.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 gec = new Form2();
            this.Hide();
            gec.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form7 gec = new Form7();
            this.Hide();
            gec.Show();
        }
        int say = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            say++;
            if (say % 2 == 0)
            {
                label2.ForeColor = Color.Gold;
            }
            if (say % 2 == 1)
            {
                label2.ForeColor = Color.Red;
            }
        }
    }
}
