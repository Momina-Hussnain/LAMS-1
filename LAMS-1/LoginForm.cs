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

namespace LAMS_1
{
    public partial class LoginForm : Form
    {
        private SqlConnection connection = new SqlConnection("data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True");

        public LoginForm()
        {
            InitializeComponent();
        }
        

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Account WHERE username = @Username AND password = @Password", connection);
                cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Login successful!");
                    Dashboard dForm = new Dashboard();
                    dForm.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            this.Hide();
            createAccount.Show();
        }
    }
}
