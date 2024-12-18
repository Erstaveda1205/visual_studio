using System; // Namespace untuk fungsi dasar.
using System.Data; // Namespace untuk manipulasi data.
using System.Collections.Generic; // Namespace untuk penggunaan koleksi seperti List.
using System.Windows.Forms; // Namespace untuk elemen GUI.

namespace DataPegawai
{
    public partial class Form1 : Form
    {
        // List untuk menyimpan data pegawai
        private List<Pegawai> pegawaiList = new List<Pegawai>();

        public Form1()
        {
            InitializeComponent(); // Inisialisasi komponen form.
        }

        // Event handler untuk tombol "View" (menambahkan data ke daftar dan menampilkan di DataGridView)
        private void btnView_Click(object sender, EventArgs e)
        {
            // Membuat objek Pegawai dari input pengguna
            Pegawai pegawai = new Pegawai
            {
                IDPegawai = txtIDPegawai.Text, // Mengambil ID Pegawai dari textbox
                NamaPegawai = txtNamaPegawai.Text, // Mengambil Nama Pegawai dari textbox
                Posisi = txtPosisi.Text, // Mengambil Posisi Pegawai dari textbox
                Gaji = decimal.Parse(txtGaji.Text) // Mengambil Gaji Pegawai dari textbox dan mengonversinya ke decimal
            };

            // Menambahkan objek Pegawai ke list pegawai
            pegawaiList.Add(pegawai);

            // Menampilkan daftar pegawai di DataGridView
            dataGridView1.DataSource = null; // Reset DataGridView untuk pembaruan data
            dataGridView1.DataSource = pegawaiList; // Mengisi DataGridView dengan data dari pegawaiList
        }

        // Kelas untuk menyimpan data Pegawai
        public class Pegawai
        {
            public string IDPegawai { get; set; } // Properti untuk ID Pegawai
            public string NamaPegawai { get; set; } // Properti untuk Nama Pegawai
            public string Posisi { get; set; } // Properti untuk Posisi
            public decimal Gaji { get; set; } // Properti untuk Gaji
        }

        // Event handler untuk tombol "Clear" (menghapus input di textbox)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIDPegawai.Clear(); // Mengosongkan textbox ID Pegawai
            txtNamaPegawai.Clear(); // Mengosongkan textbox Nama Pegawai
            txtPosisi.Clear(); // Mengosongkan textbox Posisi
            txtGaji.Clear(); // Mengosongkan textbox Gaji
        }

        // Event handler untuk tombol "Tampilkan Data Pegawai"
        private void btnTampilkanDataPegawai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; // Reset DataGridView
            dataGridView1.DataSource = pegawaiList; // Menampilkan daftar pegawai yang sudah ada
        }
    }
}
