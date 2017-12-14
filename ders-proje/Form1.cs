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

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Musteriler frm2 = new Musteriler();
            frm2.MdiParent = this;
            frm2.Show();
        }
    }
}
