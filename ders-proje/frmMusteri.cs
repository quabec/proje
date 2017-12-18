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
    public partial class frmMusteri : Form
    {
        Musteri musteri = new Musteri();
        public frmMusteri()
        {
            InitializeComponent();
        }

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            musteri.musteriAd = txtAd.Text;
            musteri.musteriSoyad = txtSoyad.Text;
            musteri.musteriNo = Convert.ToInt16(txtMNO.Text);
            musteri.MusteriEkle(musteri);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            musteri.MusteriSil(Convert.ToInt16(txt_musteri_no.Text));
           
        }
    }
}
