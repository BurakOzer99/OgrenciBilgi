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
   
    public partial class OgrenciBilgi : Form
    {
    
        public OgrenciBilgi()
        {
            InitializeComponent();
        }
        public OgrenciBilgi(List<Ogrenciekle> ilist, List<OgretmenEkle> iliste, List<notekle> notlist)
        {
            InitializeComponent();
            ogrencilist = ilist;
            ogretmenlist = iliste;
            notgiris = notlist;
            dataGridView1.DataSource = ogrencilist;

        }
        List<Ogrenciekle> ogrencilist = new List<Ogrenciekle>();
        List<OgretmenEkle> ogretmenlist = new List<OgretmenEkle>();
        List<notekle> notgiris = new List<notekle>();

        private void OgrenciBilgi_Load(object sender, EventArgs e)
        {

        }
        int sayac;
        private void btnOgrencıEkle_Click(object sender, EventArgs e)
        {
            Ogrenciekle ekle = new Ogrenciekle();
            ekle.id = sayac;

            ekle.ad = txtOgrencıAd.Text;
            ekle.soyad = txtOgrencıSoyad.Text;
            ekle.dogumtarihi = txtOgrencıDogumT.Text;
            ekle.cinsiyet = txtOgrencıCınsıyet.Text;
            ekle.Sınıf = txtOgrencıSınıf.Text;
            ekle.tcNo = txtOgrencıTc.Text;
            ogrencilist.Add(ekle);

            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = ogrencilist;
            sayac++;
        }

        private void btnOgrencıDuzenle_Click(object sender, EventArgs e)
        {
            Ogrenciekle o = new Ogrenciekle();
            o.ad = txtOgrencıAd.Text;
            o.soyad = txtOgrencıSoyad.Text;
            o.dogumtarihi = txtOgrencıDogumT.Text;
            o.cinsiyet = txtOgrencıCınsıyet.Text;
            o.Sınıf = txtOgrencıSınıf.Text;
            o.tcNo = txtOgrencıTc.Text;
            o.id = Convert.ToInt32(label7.Text);
            for (int i = 0; i < ogrencilist.Count(); i++)
            {
                if (ogrencilist[i].id == o.id)
                {
                    ogrencilist[i] = o;
                }

            }
            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = ogrencilist;
        }

        private void btnOgrencıSıl_Click(object sender, EventArgs e)
        {
            Ogrenciekle s = new Ogrenciekle();
            s.ad = txtOgrencıAd.Text;
            s.id = Convert.ToInt32(label7.Text);
            s.soyad = txtOgrencıSoyad.Text;
            s.dogumtarihi = txtOgrencıDogumT.Text;
            s.cinsiyet = txtOgrencıCınsıyet.Text;
            s.Sınıf = txtOgrencıSınıf.Text;
            s.tcNo = txtOgrencıTc.Text;

            for (int i = 0; i < ogrencilist.Count(); i++)
            {
                if (ogrencilist[i].ad == s.ad)
                {
                    ogrencilist.RemoveAt(i);
                    break;
                }

            }
            dataGridView1.DataSource = " ";
            dataGridView1.DataSource = ogrencilist;
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

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            Form1 ogrencıkayıt = new Form1(ogrencilist, ogretmenlist, notgiris);
            ogrencıkayıt.Show();
            this.Hide();
        }

        private void txtOgrencıAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtOgrencıSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtOgrencıDogumT_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOgrencıCınsıyet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
           
        }

        private void txtOgrencıSınıf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOgrencıTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtOgrencıTc_TextChanged(object sender, EventArgs e)
        {
            if (txtOgrencıTc.Text.Length >11 )
            {
                DialogResult sonuc;
                sonuc = MessageBox.Show("lüften 11 haneli olan Tc numaranızı giriniz ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOgrencıTc.Clear();
            }
        }

        private void txtOgrencıDogumT_TextChanged(object sender, EventArgs e)
        {
            txtOgrencıDogumT.MaxLength = 4;
        }

        private void txtOgrencıCınsıyet_TextChanged(object sender, EventArgs e)
        {
            if (txtOgrencıCınsıyet.Text == "E"||txtOgrencıCınsıyet.Text=="K"|| txtOgrencıCınsıyet.Text == "e" || txtOgrencıCınsıyet.Text == "k")
            {
                MessageBox.Show("cinsiyeti doğru seçtiniz");
            }
            else if (txtOgrencıCınsıyet.Text != "E" || txtOgrencıCınsıyet.Text != "K")
            {
                MessageBox.Show("Kadın için 'K' erkek için 'E' tuşuna basınız. Büyük küçük  harfa duyarlıdır");
                txtOgrencıCınsıyet.Clear();
            }
            
        }

        private void txtOgrencıSınıf_TextChanged(object sender, EventArgs e)
        {
            txtOgrencıSınıf.MaxLength =1;
           


        }
    }
}
