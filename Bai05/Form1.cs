using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            sum =  double.Parse(textBox1.Text) + double.Parse(textBox2.Text);
            textBox3.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sub = 0;
            sub = double.Parse(textBox1.Text) - double.Parse(textBox2.Text);
            textBox3.Text = sub.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double tich = 0;
            tich = double.Parse(textBox1.Text) * double.Parse(textBox2.Text);
            textBox3.Text= tich.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
            {
                MessageBox.Show("Ket qua khong hop le");
                return;
            }
            double thuong = 0;
            thuong = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
            textBox3.Text = thuong.ToString();
        }
    }
}
