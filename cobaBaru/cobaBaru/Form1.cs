using System.Runtime.InteropServices.Marshalling;

namespace cobaBaru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string textbox = "";
            textbox = txtIsi.Text;
            listBox1.Items.Add($"{textbox}");
        }
       private void button2_Click(object sender, EventArgs e)
        {
            txtIsi.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
