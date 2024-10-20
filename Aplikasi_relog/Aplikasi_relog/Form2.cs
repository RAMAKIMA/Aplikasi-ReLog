using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_relog
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            if (textBox3.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox1.Text != textBox2.Text)
            {
                button1.Enabled = false;
            }
            else if (textBox1.Text == textBox2.Text)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                button1.Enabled = false;
            }
            else if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != textBox2.Text)
            {
                button1.Enabled = false;
            }
            else if (textBox1.Text == textBox2.Text)
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            
            form.Show();

            this.Hide();
        }
    }
}
