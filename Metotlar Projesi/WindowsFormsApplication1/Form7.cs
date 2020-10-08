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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form4 gec = new Form4();
            this.Hide();
            gec.Show();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Form2 gec = new Form2();
            this.Hide();
            gec.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.BackColor = Color.Red;
            }
            if (radioButton2.Checked)
            {
                label2.BackColor = Color.Green;
            }
            if (radioButton3.Checked)
            {
                label3.BackColor = Color.Green;
            }
            if (radioButton4.Checked)
            {
                label3.BackColor = Color.Red;
            }
            if (radioButton5.Checked)
            {
                label4.BackColor = Color.Red;
            }
            if (radioButton6.Checked)
            {
                label4.BackColor = Color.Green;
            }
            if (radioButton7.Checked)
            {
                label5.BackColor = Color.Red;
            }
            if (radioButton8.Checked)
            {
                label5.BackColor = Color.Green;
            }
            if (radioButton9.Checked)
            {
                label1.BackColor = Color.Green;
            }
            if (radioButton10.Checked)
            {
                label1.BackColor = Color.Red;
            }

            if (radioButton2.Checked && radioButton3.Checked && radioButton6.Checked && radioButton8.Checked && radioButton9.Checked)
            {
                MessageBox.Show("Bütün Hepsi Doğru Tebrikler");
            }
            else 
            {
                MessageBox.Show("Hepsi Doğru Deil Tekrar Deneyin");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            
        }
    }
}
