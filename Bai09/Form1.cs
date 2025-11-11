using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked) 
                checkBox2.Checked = false;
            checkBox1 .Checked = true;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox1.Checked = false;
            checkBox2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                if (listBox1.SelectedItem.ToString() == listBox2.Items[i].ToString())
                {
                    check= false;
                    break;
                }    
            }
            if (check)
                listBox2.Items.Add(listBox1.SelectedItem.ToString());
            else
                MessageBox.Show("Môn học đã được chọn, vui lòng chọn môn khác");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||  textBox2.Text == "" || ( checkBox1.Checked == false && checkBox2.Checked == false))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }    
            int n = listBox2.Items.Count;
            int row = dataGridView1.Rows.Add();
            dataGridView1.Rows[row].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[row].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[row].Cells[2].Value = comboBox1.Text;
            if (checkBox1.Checked)
            dataGridView1.Rows[row].Cells[3].Value = "Nam";
            else
            dataGridView1.Rows[row].Cells[3].Value = "Nữ";
            dataGridView1.Rows[row].Cells[4].Value = n.ToString();
            textBox1.Clear();
            textBox2.Clear();
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            listBox2.Items.Clear();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }
    }
}
