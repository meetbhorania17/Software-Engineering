using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming Form4 is another form you want to open
            Form4 form4 = new Form4();
            form4.Show();

            // Optionally, you can hide or close the current form
            // this.Hide(); // to hide the current form
            // this.Close(); // to close the current form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the text in TextBox controls
            textBox1.Clear(); // Clear Company Name
            textBox4.Clear(); // Clear Software Type
            textBox3.Clear(); // Clear Company Website

            // Optionally, you can clear more TextBoxes if needed
            // textBox2.Clear(); // Clear Software Name

            // You can also reset other controls like ComboBoxes, Checkboxes, etc. if you have them on your form.

            // If you want to set any default values, you can do so here.

            // Focus on the first TextBox after resetting (optional)
            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
