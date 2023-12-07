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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the text in TextBox controls
            textBox1.Clear(); // Clear Company Name
            textBox2.Clear(); // Clear Software Name
            textBox3.Clear(); // Clear Company Website
            textBox4.Clear(); // Clear Software Type
            textBox5.Clear(); // Clear Description
            textBox6.Clear(); // Clear Product 2 Details (You can add more TextBoxes if needed)
            textBox7.Clear(); // Clear Software Type for Product 2 (You can add more TextBoxes if needed)
            textBox8.Clear(); // Clear Company Website for Product 2 (You can add more TextBoxes if needed)
            textBox9.Clear(); // Clear Software Name for Product 2 (You can add more TextBoxes if needed)
            textBox10.Clear(); // Clear Company Name for Product 2 (You can add more TextBoxes if needed)

            // You can set other controls (e.g., ComboBoxes, Checkboxes) to their initial states if needed.

            // Focus on the first TextBox after resetting (optional)
            textBox1.Focus();
        }
    }
}
