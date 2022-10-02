using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week2.Day3 {
    public partial class frmSinifYoklamasi : Form {
        public frmSinifYoklamasi() {
            InitializeComponent();
            //2. form
        }
        private void frmSinifListesi_Load(object sender, EventArgs e) {
            btnSil.Visible = false;
            btnDuzenle.Visible = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e) {
            string adi = txtIsim.Text;
            string durum = txtDurumu.Text;

            lstOgrenciler.Items.Add(adi);
            lstDurumlari.Items.Add(durum);
        }

        private void lstOgrenciler_Click(object sender, EventArgs e) {
            btnSil.Visible = true;
            lstDurumlari.SelectedIndex = lstOgrenciler.SelectedIndex;
        }

        private void btnSil_Click(object sender, EventArgs e) {
            int sirasi = lstOgrenciler.SelectedIndex;
            lstOgrenciler.Items.RemoveAt(sirasi);
            lstDurumlari.Items.RemoveAt(sirasi);
            btnSil.Visible = false;
        }

        private void lstOgrenciler_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstOgrenciler.SelectedIndex != -1) {
                btnDuzenle.Visible = true;
                btnSil.Visible = true;
                txtIsim.Text = lstOgrenciler.SelectedItem.ToString();
                txtDurumu.Text = lstDurumlari.SelectedItem.ToString();
            }

        }

        private void btnDuzenle_Click(object sender, EventArgs e) {
            int sira = lstOgrenciler.SelectedIndex;
            lstOgrenciler.Items.RemoveAt(sira);
            lstOgrenciler.Items.Insert(sira, txtIsim.Text);

            lstDurumlari.Items.RemoveAt(sira);
            lstDurumlari.Items.Insert(sira, txtDurumu.Text); 
        }
    }
}
