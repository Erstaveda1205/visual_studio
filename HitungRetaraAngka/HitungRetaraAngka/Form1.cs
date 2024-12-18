using System;
using System.Windows.Forms;

namespace HitungRetaraAngka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil teks dari input pengguna
                string input1 = txtAngka1.Text;
                string input2 = txtAngka2.Text;
                string input3 = txtAngka3.Text;

                // Hitung panjang teks
                int panjang1 = input1.Length;
                int panjang2 = input2.Length;
                int panjang3 = input3.Length;

                // Hitung rata-rata panjang huruf 
                double rerata = (panjang1 + panjang2 + panjang3) / 3.0;

                // Tampilkan hasil 
                txtHasil.Text = rerata.ToString("f2");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi Kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Mengosongkan semua TextBox
            txtAngka1.Clear();
            txtAngka2.Clear();
            txtAngka3.Clear();
            txtHasil.Clear();

            // Mengatur fokus kembali ke TextBox pertama
            txtAngka1.Focus();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            // Menutup aplikasi
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Event yang dipanggil saat Form dimuat (tidak wajib digunakan)
        }
    }
}
