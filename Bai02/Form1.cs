using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Bai02
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = rand.Next(0, this.ClientSize.Width - 120);
            int y = rand.Next(0, this.ClientSize.Height - 40);
            Brush brush = new SolidBrush(Color.FromArgb(0, 0, 0));
            g.DrawString("Paint event",new Font("Arial",14,FontStyle.Bold), brush, x, y);
            brush.Dispose();
        }

    }
}
