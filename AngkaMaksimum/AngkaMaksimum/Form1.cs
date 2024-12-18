namespace AngkaMaksimum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Mengambil input dari pengguna
                double angka1 = Convert.ToDouble(txtAngka1.Text);
                double angka2 = Convert.ToDouble(txtAngka2.Text);

                // Menghitung nilai maksimum
                double hasil = Math.Max(angka1, angka2);

                // Menampilkan hasil
                txtAngkaMaksimum.Text = hasil.ToString();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika input tidak valid
                MessageBox.Show("Masukkan angka yang valid! \n" 
                    + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Membersihkan semua TextBox
            txtAngka1.Clear();
            txtAngka2.Clear();
            txtAngkaMaksimum.Clear();

            // Fokus ke TextBox pertama
            txtAngka1.Focus();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Menutup aplikasi
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
