using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<Ogrenciekle> ilist, List<OgretmenEkle> iliste, List<notekle> notlist)
        {
            InitializeComponent();
            ogrencilist = ilist;
            ogretmenlist = iliste;
            notgiris = notlist;

        }
        List<Ogrenciekle> ogrencilist = new List<Ogrenciekle>();
        List<OgretmenEkle> ogretmenlist = new List<OgretmenEkle>();
        List<notekle> notgiris = new List<notekle>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrencıKayıt_Click(object sender, EventArgs e)
        {
            OgrenciBilgi Form1 = new OgrenciBilgi(ogrencilist, ogretmenlist, notgiris);
            Form1.Show();
            this.Hide();
        }

        private void btnOgretmenBılgı_Click(object sender, EventArgs e)
        {
            OgretmenBilgi ogrt = new OgretmenBilgi(ogrencilist, ogretmenlist, notgiris);
            ogrt.Show();
            this.Hide();
        }

        private void BtnSınavKayıt_Click(object sender, EventArgs e)
        {
            NotGiris ekle = new NotGiris(ogretmenlist, ogrencilist, notgiris);
            ekle.Show();
            this.Hide();
        }
    }
}
