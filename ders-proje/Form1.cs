using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteri frmMusteri = new frmMusteri();
            frmMusteri.MdiParent = this;
            frmMusteri.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
