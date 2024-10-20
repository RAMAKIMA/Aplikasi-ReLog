namespace Aplikasi_relog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (textBox1.Text == "")
            {
                Login.Enabled = false;
            }
            else if (textBox2.Text == "")
            {
                Login.Enabled = false;
            }
            else
            {
                Login.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();

            form2.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            this.Hide();

            form3.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Login.Enabled = false;
            }
            else if (textBox2.Text == "")
            {
                Login.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                Login.Enabled = false;
            }
            else
            {
                Login.Enabled = true;
            }
        }
    }
}
