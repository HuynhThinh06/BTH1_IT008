using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GhiSuKien("Constructor Form1()");

            // Gắn các sự kiện vòng đời của Form
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivate;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;
        }

        private void GhiSuKien(string tenSuKien)
        {
            string thoiGian = DateTime.Now.ToString("HH:mm:ss.fff");
            listBox1.Items.Add($"{thoiGian} - {tenSuKien}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GhiSuKien("Form1_Load");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            GhiSuKien("Form1_Shown");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            GhiSuKien("Form1_Activated");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            GhiSuKien("Form1_Deactivate");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GhiSuKien("Form1_FormClosing");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            GhiSuKien("Form1_FormClosed");
        }

        // Khi nhấn nút mở Form con
        private void button1_Click(object sender, EventArgs e)
        {
            GhiSuKien("Tạo FormCon()");
            Formcon f2 = new Formcon(this);
            f2.Show();
        }

        // Cho phép FormCon gọi hàm này để ghi sự kiện của nó vào ListBox cha
        public void GhiSuKienCon(string tenSuKien)
        {
            string thoiGian = DateTime.Now.ToString("HH:mm:ss.fff");
            listBox1.Items.Add($"{thoiGian} - [FormCon] {tenSuKien}");
        }

    }
}
