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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int say;
        private void Button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval = 1000;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            say++;
            if (say == 2)
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                label2.Visible = true;
            }
            if (say == 3)
            {
                label1.Visible = true;
            }
            if (say == 5)
            {
                timer1.Stop();
                pictureBox2.Visible = true;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            pictureBox2.Visible = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form3 gec = new Form3();
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
            Form6 gec = new Form6();
            this.Hide();
            gec.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form4 gec = new Form4();
            this.Hide();
            gec.Show();
        }
    }
}
