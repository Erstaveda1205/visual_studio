using System; // Menggunakan namespace untuk fungsi dasar .NET.
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms; // Untuk elemen GUI.
using System.Runtime.CompilerServices;
namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inisialisasi komponen form.
        }
        // Event handler untuk tombol "Tambah"
        private void BtnTambah_Click(object sender, EventArgs e)
        {
            if (TryParseInputs(out int Angka1, out int Angka2)) // Memeriksa validitas input.
            {
                int Hasil = Angka1 + Angka2; // Melakukan operasi penjumlahan.
                txtHasil.Text = Hasil.ToString(); // Menampilkan hasil.
            }
        }
        // Event handler untuk tombol "Kurang"
        private void BtnKurang_Click(object sender, EventArgs e)
        {
            if (TryParseInputs(out int Angka1, out int Angka2))
            {
                int Hasil = Angka1 - Angka2; // Melakukan operasi pengurangan.
                txtHasil.Text = Hasil.ToString(); // Menampilkan hasil.
            }
        }
        // Event handler untuk tombol "Kali"
        private void BtnKali_Click(object sender, EventArgs e)
        {
            if (TryParseInputs(out int Angka1, out int Angka2))
            {
                int Hasil = Angka1 * Angka2; // Melakukan operasi perkalian.
                txtHasil.Text = Hasil.ToString(); // Menampilkan hasil.
            }
        }
        // Event handler untuk tombol "Bagi"
        private void BtnBagi_Click(object sender, EventArgs e)
        {
            if (TryParseInputs(out int Angka1, out int Angka2))
            {
                if (Angka2 != 0) // Memastikan pembagi tidak nol.
                {
                    double Hasil = (double)Angka1 / Angka2; // Operasi pembagian.
                    txtHasil.Text = Hasil.ToString("0.##"); // Menampilkan hasil dengan format hingga 2 desimal.
                }
                else
                {
                    // Pesan kesalahan jika pembagi adalah nol.
                    MessageBox.Show("Tidak bisa membagi dengan nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Event handler untuk tombol "Clear"
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtAngka1.Text = ""; // Mengosongkan input angka pertama.
            txtAngka2.Text = ""; // Mengosongkan input angka kedua.
            txtHasil.Text = ""; // Mengosongkan hasil.
        }
        // Event handler untuk tombol "Exit"
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Menutup form.
        }
        // Fungsi untuk menvalidasi dan parsing input angka
        private bool TryParseInputs(out int angka1, out int angka2)
        {
            if (!int.TryParse(txtAngka1.Text, out angka1)) // Memeriksa apakah input angka pertama valid.
            {
                // Pesan kesalahan jika input tidak valid.
                MessageBox.Show("Angka yang kamu masukan salah!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAngka1.Focus(); // Mengatur fokus kembali ke input pertama.
                angka2 = 0; // Menginisialisasi nilai default angka kedua.
                return false; // Mengembalikan false jika input salah.
            }
            if (!int.TryParse(txtAngka2.Text, out angka2)) // Memeriksa apakah input angka kedua valid.
            {
                // Pesan kesalahan jika input tidak valid.
                MessageBox.Show("Angka yang kamu masukan salah!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAngka2.Focus(); // Mengatur fokus kembali ke input kedua.
                return false; // Mengembalikan false jika input salah.
            }
            return true; // Mengembalikan true jika kedua input valid.
        }
    }
}
