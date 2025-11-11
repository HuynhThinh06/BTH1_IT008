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
    public partial class Formcon : Form
    {
        Form1 formCha;

        public Formcon(Form1 cha)
        {
            InitializeComponent();
            formCha = cha;

            formCha.GhiSuKienCon("Constructor FormCon()");

            // Gắn sự kiện vòng đời
            this.Load += Formcon_Load;
            this.Shown += Formcon_Shown;
            this.Activated += Formcon_Activated;
            this.Deactivate += Formcon_Deactivate;
            this.FormClosing += Formcon_FormClosing;
            this.FormClosed += Formcon_FormClosed;
        }
        private void Formcon_Load(object sender, EventArgs e)
        {
            formCha.GhiSuKienCon("FormCon_Load");
        }

        private void Formcon_Shown(object sender, EventArgs e)
        {
            formCha.GhiSuKienCon("FormCon_Shown");
        }

        private void Formcon_Activated(object sender, EventArgs e)
        {
            formCha.GhiSuKienCon("FormCon_Activated");
        }

        private void Formcon_Deactivate(object sender, EventArgs e)
        {
            formCha.GhiSuKienCon("FormCon_Deactivate");
        }

        private void Formcon_FormClosing(object sender, FormClosingEventArgs e)
        {
            formCha.GhiSuKienCon("FormCon_FormClosing");
        }

        private void Formcon_FormClosed(object sender, FormClosedEventArgs e)
        {
            formCha.GhiSuKienCon("FormCon_FormClosed");
        }


    }
}
