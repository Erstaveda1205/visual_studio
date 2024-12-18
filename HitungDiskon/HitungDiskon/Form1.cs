using System.Windows.Forms.VisualStyles;

namespace HitungDiskon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            //Textbox tidak bisa diubah/diblock/diinputkan 
            txtBayar.Enabled = false;
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            // Deklarasi Variabel
            double TotalBelanja, Diskon, DiskonDapet, Sisa;
            TotalBelanja = double.Parse(txtTotal.Text);
            Diskon = double.Parse(txtDiskon.Text);
            DiskonDapet = ((double)Diskon / 100.0 * (double)TotalBelanja);
            Sisa = TotalBelanja - DiskonDapet;
            txtBayar.Text = Sisa.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtDiskon.Clear();
            txtBayar.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
