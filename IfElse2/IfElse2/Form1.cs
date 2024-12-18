namespace IfElse2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int nilai = 0;
            nilai = int.Parse(txtNilai.Text);
            String grade = "";
            if (nilai < 50)
                grade = "E";
            else if (nilai < 60)
                grade = "D";
            else if (nilai < 70)
                grade = "C";
            else if (nilai < 80)
                grade = "B";
            else if (nilai <= 100)
                grade = "A";
            else if (nilai > 100)
                grade = "";
            {
                MessageBox.Show("Nilai tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listBox1.Items.Add($"{nilai} {grade}");
        }
        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtNilai.Clear();
            listBox1.Items.Clear();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
