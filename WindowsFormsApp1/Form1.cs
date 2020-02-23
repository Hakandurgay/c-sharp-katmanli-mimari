using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  EntityLayer;
using  FacadeLayer;
using  BusinessLogicLayer;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void OgrenciListesi()
        {
            List<EntityOgrenci> OgrList = BLLOgrenci.OgrenciListele();
            dataGridView1.DataSource = OgrList;
            this.Text = "Öğrenci Listesi";
        }

        void notListesi()
        {
            List<EntityNotlar> notList = BLLNotlar.NotListele();
            dataGridView1.DataSource = notList;
            this.Text = "Not Listesi";
        }
        void KulupListele()
        {
            List<EntityKulup> kulupList = BLLKULUP.Listele();
            comboOgrKulup.DisplayMember = "KULUPAD";  //comboboxta gözükecek değer
            comboOgrKulup.ValueMember = "KULUPID"; //arkaplanda çalışacak değer 
            comboOgrKulup.DataSource = kulupList;
            dataGridView1.DataSource = kulupList;
            this.Text = "Kulüp Listesi";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OgrenciListesi();      
          //  KulupListele();
            
        }

        private void btnOgrKaydet_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent=new EntityOgrenci();
            ent.Ad = txtOgrAd.Text;
            ent.Soyad = txtOgrSoyad.Text;
            ent.Fotograf = txtOgrFotograf.Text;
            ent.Kulupid = Convert.ToInt16(comboOgrKulup.SelectedValue);
            BLLOgrenci.OgrenciEkle(ent);
            MessageBox.Show("Öğrenci Kaydı Yapıldı");
            OgrenciListesi();
        }

        private void btnOgrGuncelle_Click(object sender, EventArgs e)
        {
            EntityOgrenci ent = new EntityOgrenci();
            ent.Ad = txtOgrAd.Text;
            ent.Soyad = txtOgrSoyad.Text;
            ent.Fotograf = txtOgrFotograf.Text;
            ent.Kulupid = Convert.ToInt16(comboOgrKulup.SelectedValue);
            ent.Id = Convert.ToInt16(txtOgrId.Text);
            BLLOgrenci.Guncelle(ent);
            MessageBox.Show("Öğrenci Bilgileri Güncellendi");
            OgrenciListesi();
        }

        private void btnNotListele_Click(object sender, EventArgs e)
        {
            notListesi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Text == "Not Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtOgrId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtOgrAd.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                txtOgrSoyad.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
                txtNotSinav1.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtNotSinav2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtNotSinav3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                txtNotProje.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                txtNotOrtalama.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                txtNotDurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            }
            else if (this.Text == "Öğrenci Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtOgrId.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtOgrAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                txtOgrSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            }
            else if (this.Text == "Kulüp Listesi")
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                txtKulupAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtKulupId.Text= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            }
        }

        private void btnNotGuncelle_Click(object sender, EventArgs e)
        {
            EntityNotlar ent=new EntityNotlar();
            ent.OgrenciId = Convert.ToInt16(txtOgrId.Text);
            ent.Sinav1 = Convert.ToInt16(txtNotSinav1.Text);
            ent.Sinav2 = Convert.ToInt16(txtNotSinav2.Text);
            ent.Sinav3 = Convert.ToInt16(txtNotSinav3.Text);
            ent.Proje = Convert.ToInt16(txtNotProje.Text);
            ent.Ortalama = Convert.ToInt16(txtNotOrtalama.Text);
            ent.Durum = txtNotDurum.Text;
            BLLNotlar.NotGuncelle(ent);
            MessageBox.Show("Notlar Güncellendi");
            notListesi();


        }

        private void btnNotHesapla_Click(object sender, EventArgs e)
        {
            int s1=0, s2=0, s3=0, proje=0;
            double ortalama=0;
            string durum;
            s1 = Convert.ToInt16(txtNotSinav1.Text);
            s2 = Convert.ToInt16(txtNotSinav2.Text);
            s3 = Convert.ToInt16(txtNotSinav3.Text);
            proje = Convert.ToInt16(txtNotProje.Text);
            ortalama = (s1 + s2 + s3 + proje) / 4;
            txtNotOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50)
                durum = "True";
            else
            {
                durum = "False";
            }

            txtNotDurum.Text = durum;
        }

        private void btnKulupListele_Click(object sender, EventArgs e)
        {
            KulupListele();

        }

        private void btnKulupKaydet_Click(object sender, EventArgs e)
        {
            EntityKulup ent=new EntityKulup();
            ent.KulupAd = txtKulupAd.Text;
            BLLKULUP.KulupEkle(ent);
            KulupListele();
        }

        private void btnKulupSil_Click(object sender, EventArgs e)
        {
            EntityKulup ent=new EntityKulup();
            ent.KulupId = Convert.ToInt16(txtKulupId.Text);
            BLLKULUP.sil(ent.KulupId);
            KulupListele();
        }

        private void BtnKulupGuncelle_Click(object sender, EventArgs e)
        {
            EntityKulup ent=new EntityKulup();
            ent.KulupAd = txtKulupAd.Text;
            ent.KulupId = Convert.ToInt16(txtKulupId.Text);
            BLLKULUP.KulupGuncelle(ent);
        }
    }
}
