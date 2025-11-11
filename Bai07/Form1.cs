using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Form1 : Form
    {
        int[] seatCheck = new int[15];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (seatCheck[0] == 0)
            {
                seatCheck[0] = 1;
                button1.BackColor = Color.Blue;
            }
            else
            if (seatCheck[0] == 1)
            {
                seatCheck[0] = 0;
                button1.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (seatCheck[1] == 0)
            {
                seatCheck[1] = 1;
                button2.BackColor = Color.Blue;
            }
            else
            if (seatCheck[1] == 1)
            {
                seatCheck[1] = 0;
                button2.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (seatCheck[2] == 0)
            {
                seatCheck[2] = 1;
                button3.BackColor = Color.Blue;
            }
            else
            if (seatCheck[2] == 1)
            {
                seatCheck[2] = 0;
                button3.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (seatCheck[3] == 0)
            {
                seatCheck[3] = 1;
                button4.BackColor = Color.Blue;
            }
            else
            if (seatCheck[3] == 1)
            {
                seatCheck[3] = 0;
                button4.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (seatCheck[4] == 0)
            {
                seatCheck[4] = 1;
                button5.BackColor = Color.Blue;
            }
            else
            if (seatCheck[4] == 1)
            {
                seatCheck[4] = 0;
                button5.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (seatCheck[5] == 0)
            {
                seatCheck[5] = 1;
                button6.BackColor = Color.Blue;
            }
            else
            if (seatCheck[5] == 1)
            {
                seatCheck[5] = 0;
                button6.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (seatCheck[6] == 0)
            {
                seatCheck[6] = 1;
                button7.BackColor = Color.Blue;
            }
            else
            if (seatCheck[6] == 1)
            {
                seatCheck[6] = 0;
                button7.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (seatCheck[7] == 0)
            {
                seatCheck[7] = 1;
                button8.BackColor = Color.Blue;
            }
            else
            if (seatCheck[7] == 1)
            {
                seatCheck[7] = 0;
                button8.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (seatCheck[8] == 0)
            {
                seatCheck[8] = 1;
                button9.BackColor = Color.Blue;
            }
            else
            if (seatCheck[8] == 1)
            {
                seatCheck[8] = 0;
                button9.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (seatCheck[9] == 0)
            {
                seatCheck[9] = 1;
                button10.BackColor = Color.Blue;
            }
            else
            if (seatCheck[9] == 1)
            {
                seatCheck[9] = 0;
                button10.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (seatCheck[10] == 0)
            {
                seatCheck[10] = 1;
                button11.BackColor = Color.Blue;
            }
            else
            if (seatCheck[10] == 1)
            {
                seatCheck[10] = 0;
                button11.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (seatCheck[11] == 0)
            {
                seatCheck[11] = 1;
                button12.BackColor = Color.Blue;
            }
            else
            if (seatCheck[11] == 1)
            {
                seatCheck[11] = 0;
                button12.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (seatCheck[12] == 0)
            {
                seatCheck[12] = 1;
                button13.BackColor = Color.Blue;
            }
            else
            if (seatCheck[12] == 1)
            {
                seatCheck[12] = 0;
                button13.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (seatCheck[13] == 0)
            {
                seatCheck[13] = 1;
                button14.BackColor = Color.Blue;
            }
            else
            if (seatCheck[13] == 1)
            {
                seatCheck[13] = 0;
                button14.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (seatCheck[14] == 0)
            {
                seatCheck[14] = 1;
                button15.BackColor = Color.Blue;
            }
            else
            if (seatCheck[14] == 1)
            {
                seatCheck[14] = 0;
                button15.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Chỗ đã được chọn");
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < seatCheck.Length; i++)
            {
                if (seatCheck[i] == 1)
                {
                    seatCheck[i] = 0; 
                    Control[] btns = this.Controls.Find("button" + (i + 1), true);
                    if (btns.Length > 0 && btns[0] is Button)
                    {
                        ((Button)btns[0]).BackColor = Color.White; 
                    }
                }
                textBox1.Text = "0";

            }    
        }

        private void bChoose_Click(object sender, EventArgs e)
        {
            long sum = 0;
            for (int i = 0; i < seatCheck.Length; i++)
            {
                if (seatCheck[i] == 1)
                {
                    seatCheck[i] = 2;
                    Control[] btns = this.Controls.Find("button" + (i + 1), true);
                    if (btns.Length > 0 && btns[0] is Button)
                    {
                        ((Button)btns[0]).BackColor = Color.Yellow;
                    }
                    if (i >= 0 && i <= 4)
                        sum = sum + 5000;
                    else if (i >= 5 && i <= 9)
                        sum = sum + 6500;
                    else sum = sum + 8000;
                }
                textBox1.Text = sum.ToString();

            }
        }

        private void bEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
