using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;

namespace DataDiri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            lblTampil.Text = "Nama :" + txtNama.Text
                + ".\ntxtKelas :" + txtKelas.Text
                + ".\nGenre Film Favorit :" + txtFilmFavorit.Text
                + ".\nGenre Musik Favorite :" + txtMusikFavorit.Text
                + ".\nWarna favorit:" + txtWarnaFavorit.Text + "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtKelas.Text = "";
            txtFilmFavorit.Text = "";
            txtMusikFavorit.Text = "";
            txtWarnaFavorit.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
