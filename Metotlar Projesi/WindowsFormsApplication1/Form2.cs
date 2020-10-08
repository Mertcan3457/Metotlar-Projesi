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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Form3 gec = new Form3();
                this.Hide();
                gec.Show();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Form4 gec = new Form4();
                this.Hide();
                gec.Show();
            }
        }
    }
}
