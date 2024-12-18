using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) 
        {
            lblTampil.Text = "Nama:" + txtNama.Text
    + "\nKelas:" + txtKelas.Text
    + "\nGenre Film Favorit:" + txtFilm.Text
    + "\nGenre Musik Favorit:" + txtMusik.Text
    + "\nWarna Favorit:" + txtWarna.Text + "";

        }
        private void button2_Click(object sender, EventArgs e)
            {
            txtNama.Text = "";
            txtKelas.Text = "";
            txtFilm.Text = "";
            txtMusik.Text = "";
            txtWarna.Text = "";
            }
        private void button3_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
