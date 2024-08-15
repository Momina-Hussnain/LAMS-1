using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMS_1
{
    public partial class ViewStudentInfo : Form
    {
        public ViewStudentInfo()
        {
            InitializeComponent();
        }

        private void ViewStudentInfo_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEnrollment_TextChanged(object sender, EventArgs e)
        {
            if (txtEnrollment.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent where enroll LIKE '" + txtEnrollment.Text + "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEnrollment.Clear();
        }

        private void ViewStudentInfo_Click(object sender, EventArgs e)
        {

        }
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=TEAMOS-PC\\SQLEXPRESS;database=SignupForm;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                // Assuming 'bid' is a variable that should be obtained from the clicked cell
                int stuid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["stuid"].Value);
                cmd.CommandText = "select * from NewStudent where stuid=@stuid";
                cmd.Parameters.AddWithValue("@stuid", stuid);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    txtSname.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtEnroll.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtEnroll.Text = "No data found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String Student = txtSname.Text;
            String Enroll = txtEnroll.Text;
            String Dep = txtDepartment.Text;
            String Sem = txtSemester.Text;
            Int64 contact = Int64.Parse(txtContact.Text);
            String email = txtEmail.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update NewStudent set  sname='" + Student + "',enroll ='" + Enroll + "',dep= '" + Dep + "',sem= '" + Sem + "',contact= " + contact + ",email='" + email + "' where stuid=" + rowid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from NewStudent where stuid=" + rowid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSname.Clear();
            txtEnroll.Clear();
            txtDepartment.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            txtEmail.Clear();
        }
    }
}
