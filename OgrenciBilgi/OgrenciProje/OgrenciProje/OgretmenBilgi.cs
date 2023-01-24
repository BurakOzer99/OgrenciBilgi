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
    public partial class OgretmenBilgi : Form
    {
        public OgretmenBilgi()
        {
            InitializeComponent();
        }
        public OgretmenBilgi(List<Ogrenciekle> ilist, List<OgretmenEkle> iliste, List<notekle> notlist)
        {
            InitializeComponent();
            ogrencilist = ilist;
            ogretmenlist = iliste;
            notgiris = notlist;
            dataGridView1.DataSource = ogretmenlist;

        }
        List<Ogrenciekle> ogrencilist = new List<Ogrenciekle>();
        List<OgretmenEkle> ogretmenlist = new List<OgretmenEkle>();
        List<notekle> notgiris = new List<notekle>();

        private void OgretmenBilgi_Load(object sender, EventArgs e)
        {

        }
        int sayac = 1;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            OgretmenEkle ogrt = new OgretmenEkle();
            ogrt.id = sayac;
            ogrt.ad = txtOgretmenAd.Text;
            ogrt.soyad = txtOgretmenSoyad.Text;
            ogrt.brans = txtogretmenBras.Text;
            ogretmenlist.Add(ogrt);
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = ogretmenlist;
            sayac++;

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            OgretmenEkle ogrtsil = new OgretmenEkle();
            //ogrtsil.id = Convert.ToInt32(label4.Text) ;
            ogrtsil.ad = txtOgretmenAd.Text;
            ogrtsil.soyad = txtOgretmenSoyad.Text;
            ogrtsil.brans = txtogretmenBras.Text;

            for (int i = 0; i < ogretmenlist.Count(); i++)
            {
                if (ogretmenlist[i].id == ogrtsil.id)
                {
                    ogretmenlist.RemoveAt(i);
                    break;
                }

            }
            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = ogretmenlist;

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(ogrencilist, ogretmenlist, notgiris);
            form1.Show();
            this.Hide();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            label4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOgretmenAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgretmenSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtogretmenBras.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtOgretmenAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtOgretmenSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void txtogretmenBras_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }
    }
}
