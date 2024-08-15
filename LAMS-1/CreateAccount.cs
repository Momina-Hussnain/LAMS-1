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
    public partial class CreateAccount : Form
    {
        private SqlConnection connection = new SqlConnection("data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True");
        public CreateAccount()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Account (username, password , confirmpassword) VALUES (@Username, @Password , @Confirmpassword)", connection);
                cmd.Parameters.AddWithValue("@Username", txtusername.Text);
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);
                cmd.Parameters.AddWithValue("@Confirmpassword", txtconfirmpassword.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User registered successfully!");
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
    }
}
