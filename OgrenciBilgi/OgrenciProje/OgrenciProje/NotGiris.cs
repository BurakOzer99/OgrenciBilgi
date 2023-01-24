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
    public partial class NotGiris : Form
    {
        public NotGiris()
        {
            InitializeComponent();
        }
        public NotGiris(List<OgretmenEkle> iliste, List<Ogrenciekle> ilist, List<notekle> notlist)
        {
            InitializeComponent();
            ogretmenlist = iliste;
            ogrencilist = ilist;
            notgiris = notlist;

            dataGridView1.DataSource = ogrencilist;
            dataGridView2.DataSource = notlist;

        }
        List<OgretmenEkle> ogretmenlist = new List<OgretmenEkle>();
        List<Ogrenciekle> ogrencilist = new List<Ogrenciekle>();
        List<notekle> notgiris = new List<notekle>();

        private void NotGiris_Load(object sender, EventArgs e)
        {

        }
        int sayac = 1;
       
        private void button3_Click(object sender, EventArgs e)
        {
            notekle gir = new notekle();
            gir.id = sayac;
            gir.ad = txtOgrencıAd.Text;
            gir.soyad = txtOgrencıSoyad.Text;
            gir.dogumtarihi = txtOgrencıDogumT.Text;
            gir.cinsiyet = txtOgrencıCınsıyet.Text;
            gir.Sınıf = txtOgrencıSınıf.Text;
            gir.tcNo = txtOgrencıTc.Text;
            gir.s1 = Convert.ToInt32(txts1.Text);
            gir.s2 = Convert.ToInt32(txt2.Text);
            gir.s3 = Convert.ToInt32(txts3.Text);
            gir.ort = Convert.ToInt32(gir.s1+gir.s2+gir.s3)/3 ;
            if (gir.ort >= 50)
            {
                gir.derece = "GEÇTİ ";
            }
            else
            {
                gir.derece = "KALDI";
            }
            notgiris.Add(gir);
            sayac++;
            dataGridView2.DataSource = "";
            dataGridView2.DataSource = notgiris;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtOgrencıAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtOgrencıSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtOgrencıDogumT.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtOgrencıCınsıyet.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtOgrencıSınıf.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtOgrencıTc.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 geri = new Form1(ogrencilist, ogretmenlist, notgiris);
            geri.Show();
            this.Hide();
        }

        private void txts1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txts3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txts1_TextChanged(object sender, EventArgs e)
        {
            if (txts1.Text.Length > 3)
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("not aralığı 0-100 arasındadır ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txts1.Clear();
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text.Length > 3)
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("not aralığı 0-100 arasındadır ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt2.Clear();
            }
        }

        private void txts3_TextChanged(object sender, EventArgs e)
        {
            if (txts3.Text.Length > 3)
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("not aralığı 0-100 arasındadır  ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txts3.Clear();
            }
        }
    }
}
