using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace login_form
{
    public partial class userLogin : Form
    {
        public userLogin()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = |DataDirectory|CitiSoftDB.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[userLogin] ([username],[Password])
            VALUES ('" + txtUsername.Text + "','" + txtLogPass.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            //MessageBox.Show("Logged in Successfully");

            homePage form3 = new homePage();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            
            txtLogPass.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form welcomeUser = new welcomeUser();
            this.Hide();
            welcomeUser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userSetup form1 = new userSetup();
            form1.Show();
            this.Hide();
        }
    }
    
}
