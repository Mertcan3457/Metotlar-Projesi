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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            pictureBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 2)
            {             
                label1.Visible = true;
                pictureBox2.Visible = true;
            }
            if (sayac == 4)
            {
                timer1.Stop();
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form2 gec = new Form2();
            this.Hide();
            gec.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form5 gec = new Form5();
            this.Hide();
            gec.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form4 gec = new Form4();
            this.Hide();
            gec.Show();
        }
    }
}
