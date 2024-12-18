namespace AngkaAcak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcak_Click(object sender, EventArgs e)
        {
            int AngkaMin = 0;
            int AngkaMax = 0;

            // Validasi input apakah angka atau tidak
            bool isNumericMin = int.TryParse(txtMin.Text, out AngkaMin);
            bool isNumericMax = int.TryParse(txtMax.Text, out AngkaMax);

            if (isNumericMin && isNumericMax)
            {
                if (AngkaMin <= AngkaMax)
                {
                    // Membuat objek random dan menghasilkan angka acak
                    Random rand = new Random();
                    int HasilAcak = rand.Next(AngkaMin, AngkaMax + 1); // +1 untuk inklusif AngkaMax
                    // Menampilkan angka acak
                    txtHasilAcak.Text = HasilAcak.ToString();
                }
                else
                {
                    MessageBox.Show("Angka Minimum harus lebih kecil atau sama dengan Angka Maksimum.",
                        "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Masukkan angka valid di kedua input!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
