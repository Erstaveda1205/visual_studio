using System;
using System.Data;
using System.Windows.Forms;

namespace PegawaiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Membuat DataTable sebagai sumber data
            DataTable dtPegawai = new DataTable();

            // Menambahkan kolom ke DataTable
            dtPegawai.Columns.Add("ID", typeof(string));
            dtPegawai.Columns.Add("Nama", typeof(string));
            dtPegawai.Columns.Add("Posisi", typeof(string));
            dtPegawai.Columns.Add("Gaji", typeof(decimal));

            // Menambahkan data contoh
            dtPegawai.Rows.Add("1", "Andi", "Manager", 1000000);
            dtPegawai.Rows.Add("2", "Budi", "Staff", 500000);
            dtPegawai.Rows.Add("3", "Citra", "Supervisor", 750000);

            // Menghubungkan DataTable dengan DataGridView
            dataGridView1.DataSource = dtPegawai;

            // Penyesuaian tampilan DataGridView
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true; // Data hanya untuk dibaca
        }
    }
}
