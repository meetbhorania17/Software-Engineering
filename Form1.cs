using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
       {
            // Clear the input fields
            textBox1.Text = string.Empty; // Company Name
            textBox2.Text = string.Empty; // Software Name
            textBox3.Text = string.Empty; // Company Website
            textBox4.Text = string.Empty; // Software Type
            textBox5.Text = string.Empty; // Description
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form3
            Form2 form3 = new Form2();

            // Show Form3
            form3.Show();

            // Optionally, you can hide or close Form1 if needed
            // this.Hide();
            // this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
