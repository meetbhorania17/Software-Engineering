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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of Form5
            Vendor.Form5 form5 = new Vendor.Form5();

            // Show Form5
            form5.Show();

            // Optionally, you can hide or close Form3 if needed
            // this.Hide(); // Hide Form3
            // this.Close(); // Close Form3
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
    }
}
