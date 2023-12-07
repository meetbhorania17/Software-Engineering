using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login_form
{
    public partial class userSetup : Form
    {
        public userSetup()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\CitiSoft\\login_form\\CitiSoftDB.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[userRegister] ([Name],[Email],[Password])
            VALUES ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "')",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Created Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form welcomeUser = new welcomeUser();
            this.Hide();
            welcomeUser.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            userLogin form2 = new userLogin();
            form2.Show();
            this.Hide();
        }
    }
}
