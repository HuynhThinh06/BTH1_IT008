using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbTaikhoan.Text == "" || tbDiachi.Text == "" || tbHoten.Text == "" || tbSotien.Text == "")
                MessageBox.Show("Vui lòng nhập đủ dữ liệu");
            else
            {
                bool tonTai = false;
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].SubItems[1].Text == tbTaikhoan.Text)
                    {
                        int soTienCu = int.Parse(listView1.Items[i].SubItems[4].Text);
                        int soTienMoi = int.Parse(tbSotien.Text);
                        listView1.Items[i].SubItems[4].Text = (soTienCu + soTienMoi).ToString();
                        tonTai = true;
                        MessageBox.Show("Cập nhật dữ liệu thành công");
                        break;
                    }
                }

                if (!tonTai)
                {
                    ListViewItem item = new ListViewItem((listView1.Items.Count + 1).ToString());
                    item.SubItems.Add(tbTaikhoan.Text);
                    item.SubItems.Add(tbHoten.Text);
                    item.SubItems.Add(tbDiachi.Text);
                    item.SubItems.Add(tbSotien.Text);
                    listView1.Items.Add(item);
                    MessageBox.Show("Thêm mới dữ liệu thành công");

                }
                tbTT.Text = (int.Parse(tbTT.Text) + int.Parse(tbSotien.Text)).ToString();
                tbTaikhoan.Clear();
                tbHoten.Clear();
                tbDiachi.Clear();
                tbSotien.Clear();
                tbTaikhoan.Focus();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool tonTai = false;
            int check = 0;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == tbTaikhoan.Text)
                {
                    check = i;
                    tonTai = true;
                    break;
                }
            }

            if (!tonTai)
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    listView1.Items.Remove(listView1.Items[check]);
                    for (int i = 0; i < listView1.Items.Count; i++)
                        listView1.Items[i].SubItems[0].Text = (i + 1).ToString();
                }
            }
            tbTaikhoan.Clear();
            tbHoten.Clear();
            tbDiachi.Clear();
            tbSotien.Clear();
            tbTaikhoan.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];

                tbTaikhoan.Text = item.SubItems[1].Text;
                tbHoten.Text = item.SubItems[2].Text;
                tbDiachi.Text = item.SubItems[3].Text;
                tbSotien.Text = item.SubItems[4].Text;
            }
        }
    }
}
