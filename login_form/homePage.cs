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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        public void load_Page(object Form)
        {
            if (this.panel3.Controls.Count > 0)
                this.panel3.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }

        private void homePage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            load_Page(new searchPage());
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            load_Page(new savedItems());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load_Page(new userProfile());
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}
