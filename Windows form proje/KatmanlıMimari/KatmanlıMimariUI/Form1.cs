using KatmanlıMimariDataAccess.Entity;
using KatmanlıMimariDataBussiness.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatmanlıMimariUI
{
    public partial class Form1 : Form
    {
        Urun urun;
        UrunManager manager;
        int id = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnHepsiniGetir_Click(object sender, EventArgs e)
        {
            manager = new UrunManager();
            dataGridUrun.DataSource = manager.HepsiniGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            manager = new UrunManager();
            int id = Convert.ToInt32(dataGridUrun.CurrentRow.Cells["Id"].Value);
            manager.Sil(id);
            dataGridUrun.DataSource = manager.HepsiniGetir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            manager = new UrunManager();
            urun = new Urun();

            urun.Adet = int.Parse(txtAdet.Text);
            urun.Fiyat = double.Parse(txtFiyat.Text);
            urun.Marka = txtMarka.Text;
            urun.UrunAdi = txtUrunAdi.Text;

            manager.Ekle(urun);
            Temizle();
            dataGridUrun.DataSource = manager.HepsiniGetir();
        }

        void Temizle()
        {
            txtUrunAdi.Clear();
            txtMarka.Clear();
            txtFiyat.Clear();
            txtAdet.Clear();
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            urun = new Urun();
            manager = new UrunManager();

            urun.ID = id;
            urun.Marka = txtMarka.Text;
            urun.UrunAdi = txtUrunAdi.Text;
            urun.Fiyat = int.Parse(txtFiyat.Text);
            urun.Adet = int.Parse(txtAdet.Text);

            manager.Guncelle(urun);
            Temizle();
            dataGridUrun.DataSource = manager.HepsiniGetir();
        }
    }
}
