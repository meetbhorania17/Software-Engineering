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
//using System.Drawing;

namespace login_form
{
    public partial class addm_login_form : Form
    {
        private string StringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mb1921\\Source\\Repos\\CitiSoft\\login_form\\CitiSoftDB.mdf;Integrated Security=True";
        public addm_login_form()
        {
            InitializeComponent();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_click(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBoxPwd.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            textBoxPwd.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBoxUsername.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPwd.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPwd.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPwd.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string roleOfUser = UserAuthentication(textBoxUsername.Text, textBoxPwd.Text);

            if (roleOfUser != null)
            {
                OpenForm(roleOfUser);
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private string UserAuthentication(string userName, string password)
        {
            using (SqlConnection connection = new SqlConnection(StringConnection))
            {
                connection.Open();
                string query = "SELECT Role FROM textBoxUsername=@Username AND textBoxPwd=@Password";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", textBoxUsername);
                    cmd.Parameters.AddWithValue("@Password", textBoxPwd);

                    object result = cmd.ExecuteScalar();

                    return result?.ToString();
                }
            }
        }
        private void OpenForm(string roleOfUser)
        {
            switch (roleOfUser)
            {
                case "admin":
                    user_access form1 = new user_access();
                    form1.Show();
                    this.Hide();
                    break;

                case "vendor":
                    Form1 form2 = new Form1();
                    form2.Show();
                    this.Hide();
                    break;

                default:
                    homePage form3 = new homePage();
                    form3.Show();
                    this.Hide();
                    break;
            }
        } 
    }
}
