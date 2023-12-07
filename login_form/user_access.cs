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
    public partial class user_access : Form
    {
        public user_access()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblValue.Text = cboBox.Text;
        }

        private void user_access_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            adding_user form2 = new adding_user();
            form2.Show();
            this.Hide();
        }

        private void btnRemoveuser_Click(object sender, EventArgs e)
        {
            remove_user removeUser = new remove_user();
            removeUser.Show();
            this.Hide();
        }

        private void btnUserAccessRights_Click(object sender, EventArgs e)
        {
            user_right_access userAccess = new user_right_access();
            userAccess.Show();
            this.Hide();
        }
    }
}
