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
    public partial class Form2 : Form
    {
        SiparisManager manager;
        UrunManager urunManager;
        Siparis siparis;
        int id = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnHepsiniGetir_Click(object sender, EventArgs e)
        {
            manager = new SiparisManager();
            dataGridSiparis.DataSource = manager.HepsiniGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            manager = new SiparisManager();
            int id = Convert.ToInt32(dataGridSiparis.CurrentRow.Cells["Id"].Value);
            manager.Sil(id);
            dataGridSiparis.DataSource = manager.HepsiniGetir();
        }

        void Temizle()
        {
            txtAdres.Clear();
            txtMusteriAdi.Clear();
            txtToplamTutar.Clear();
            cmbUrunId.SelectedItem = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            urunManager = new UrunManager();
            manager = new SiparisManager();
            siparis = new Siparis();

            int id = Convert.ToInt32(cmbUrunId.SelectedItem);
            siparis.Urun = urunManager.IdyeGoreUrunGetir(id);

            siparis.MusteriAdi = txtMusteriAdi.Text;
            siparis.ToplamTutar = double.Parse(txtToplamTutar.Text);
            siparis.Adres = txtAdres.Text;
            manager.Ekle(siparis);
            Temizle();
            dataGridSiparis.DataSource = manager.HepsiniGetir();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            urunManager = new UrunManager();
            foreach (var item in urunManager.IdleriGetir())
            {
                cmbUrunId.Items.Add(item);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            siparis = new Siparis();
            manager = new SiparisManager();
            urunManager = new UrunManager();

            siparis.Adres = txtAdres.Text;
            siparis.MusteriAdi = txtMusteriAdi.Text;
            siparis.ToplamTutar = int.Parse(txtToplamTutar.Text);
            siparis.ID = id;
            siparis.Urun = urunManager.IdyeGoreUrunGetir(Convert.ToInt32(cmbUrunId.SelectedItem));

            manager.Guncelle(siparis);
            Temizle();
            dataGridSiparis.DataSource = manager.HepsiniGetir();
        }

        private void dataGridSiparis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridSiparis.CurrentRow.Cells["Id"].Value);
            txtToplamTutar.Text = Convert.ToString(dataGridSiparis.CurrentRow.Cells["ToplamTutar"].Value);
            txtAdres.Text = Convert.ToString(dataGridSiparis.CurrentRow.Cells["Adres"].Value);
            txtMusteriAdi.Text = Convert.ToString(dataGridSiparis.CurrentRow.Cells["MusteriAdi"].Value);
        }
    }
}
