using System; // Menggunakan namespace System untuk fungsi-fungsi umum seperti string dan Random.
using System.Linq; // Menggunakan namespace System.Linq untuk manipulasi data seperti pengurutan atau filtering.
using System.Windows.Forms; // Menggunakan namespace System.Windows.Forms untuk komponen UI.

namespace AcakAngka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Inisialisasi komponen UI pada form.
        }

        // Event handler untuk tombol "Acak"
        private void BtnAcak_Click(object sender, EventArgs e)
        {
            string inputText = txtInput.Text; // Membaca teks dari kotak teks input.

            if (!string.IsNullOrEmpty(inputText)) // Memeriksa apakah input tidak kosong.
            {
                string shuffledText = ShuffleText(inputText); // Memanggil metode ShuffleText untuk mengacak teks.
                txtHasilAcak.Text = shuffledText; // Menampilkan hasil acakan di kotak teks hasil.
            }
            else
            {
                // Menampilkan pesan peringatan jika input kosong.
                MessageBox.Show("Masukkan teks terlebih dahulu!"
                    , "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Metode untuk mengacak urutan karakter dalam teks
        private string ShuffleText(string text)
        {
            Random rand = new Random(); // Membuat instance Random untuk menghasilkan angka acak.
            return new string(text.OrderBy(c => rand.Next()).ToArray());
            // Mengacak urutan karakter dalam string menggunakan LINQ dan mengembalikan hasilnya sebagai string baru.
        }

        // Event handler untuk tombol "Clear"
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty; // Mengosongkan kotak teks input.
            txtHasilAcak.Text = string.Empty; // Mengosongkan kotak teks hasil.
        }

        // Event handler untuk tombol "Exit"
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // Menutup aplikasi.
        }
    }
}
