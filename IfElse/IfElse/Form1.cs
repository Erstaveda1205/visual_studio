using System; // Berisi tipe dasar seperti console, String, Math
using System.Collections.Generic; // Berisi Koleksi generik seperti List<T>, Dictionary<Tkey, TValue>
using System.ComponentModel; // Menyediakan kelas untuk mendukung desain dan komponan runtime sering digunakan dalam pengembangan aplikasi berbasis GUI, seperti aplikasi Windows Forms
using System.Data; // Untuk bekerja dengan data, termasuk kelas untuk mengelola database(DataTable,dan DataRow)
using System.Drawing; // Untuk grafik dan manipulasi gambar(Graphic g = e.Graphic;
// g.DrawRectagle(Pens.Black, new Rectangle(10,10,100,50)));
using System.Linq; // Untuk operasi LINQ(var evenNumber = numbers.Where(n => n % 2 == 0);)
using System.Text; // Mencakup kelas2 untuk manipulasi nama antara kelas, enum, struktur, delgate, atau tipe lainnya yang mungkin memiliki nama yang sama
// namespace: mengorganisasi kode dan menghindari konflik nama antara kelas, enum, struktur, delgate, atau tipe lainnya yang mungkin memiliki nama yang sama
// Stintaks using dalam c# digunakan untuk menyertakan namespace yang berisi kumpulan kelas, fungsi, dan komponen yang dapat digunakan dalam program

namespace IfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Menampilkan form ditengah ketika dijalankan
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int nilai = 0; 
            nilai = int.Parse(txtNilai.Text);
            string grade = "";
            if (nilai < 50)
                grade = "GAGAL";
            else if (nilai < 60)
                grade = "C";
            else if (nilai < 80)
                grade = "B";
            else if (nilai < 101)
                grade = "A";
            listBox1.Items.Add($"{nilai} {grade}");
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNilai.Text = "";
            listBox1 .Items.Clear();
        }
        private void BtnExit_Click(object sender,  EventArgs e)
        {
            this.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
