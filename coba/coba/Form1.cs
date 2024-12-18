namespace coba
{
    public partial class Login : Form
    {
        // Username dan password yang benar
        private string correctUsername = "admin";
        private string correctPassword = "admin";

        public Login()
        {
            InitializeComponent();

            // Tambahkan event handler untuk tombol login
            btnLogin.Click += new EventHandler(this.btnLogin_Click);
        }

        // Event handler untuk tombol login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Ambil input dari textbox
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi username dan password
            if (username == correctUsername && password == correctPassword)
            {
                MessageBox.Show("Login Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username atau password salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
