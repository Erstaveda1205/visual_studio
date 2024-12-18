using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HitungRerata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Mengatur form untuk berada di tengah layar saat aplikasi di jalankan
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void button3_Click(object sender,  EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtAngka1.Clear();
            txtAngka2.Clear();
            txtAngka3.Clear();
            txtRerata.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Variable untuk menampung data 
            Double skor1 = 0.0;
            Double skor2 = 0.0;
            Double skor3 = 0.0;
            Double rerata = 0.0;

            // Konstanta 
            const int Jml_skor = 3;
            const Double skor_tinggi = 80.0;

            // Salin ketiga skor pada textbox ke dalam variable2
            skor1 = Double.Parse(txtAngka1.Text);
            skor2 = Double.Parse(txtAngka2.Text);
            skor3 = Double.Parse(txtAngka3.Text);

            // Menghitung skor rerata
            rerata = (skor1 + skor2 + skor3) / Jml_skor;

            // Menampilkan rerata, membulatkan menjadi 2 digit dibelakang desimal
            txtRerata.Text = rerata.ToString("n2");

            // Jika skor tertinggi berikan pujian
            if (rerata > skor_tinggi)
                label6.Text = "Selamat Nilaimu BAGUS!";
            else
                label6.Text = "Silahkan Berlatih lagi, Tetap Semangat!";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
