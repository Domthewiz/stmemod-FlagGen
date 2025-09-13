namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f2 = new smm2stuffgen();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form f2 = new smm2stuffgen();
            f2.Show();
            f2.Focus();
        }

        private void Form1_Enter(object sender, EventArgs e)
        {

        }
    }
}
