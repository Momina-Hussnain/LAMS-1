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
using System.Diagnostics;
using System.Xml.Linq;

namespace LAMS_1
{
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViewBook_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewBook";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

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
                int bid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["bid"].Value);
                cmd.CommandText = "select * from NewBook where bid=@bid";
                cmd.Parameters.AddWithValue("@bid", bid);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    txtBName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtPublication.Text = ds.Tables[0].Rows[0][3].ToString();
                    txtPDate.Text = ds.Tables[0].Rows[0][4].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    txtBName.Text = "No data found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            String bname = txtBName.Text;
            String bauthor = txtAuthor.Text;
            String publication = txtPublication.Text;
            String pdate = txtPDate.Text;
            Int64 price = Int64.Parse(txtPrice.Text);
            Int64 quan = Int64.Parse(txtQuantity.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update NewBook set bName = '" + bname + "',bAuthor ='" + bauthor + "',bPub1= '" + publication + "',bPDate= '" + pdate + "',bPrice= " + price + ",bQuan=" + quan + " where bid=" + rowid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewBook where bName LIKE '" + txtBookName.Text + "%'";
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

                cmd.CommandText = "select * from NewBook";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = TEAMOS-PC\\SQLEXPRESS; database = SignupForm ;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from NewBook where bid=" + rowid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtPDate.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }
    }
}
