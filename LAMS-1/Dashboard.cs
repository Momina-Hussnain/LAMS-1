using LAMS_1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMS_1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private int imageno = 1;
        private void loadingnextimage()
        {
            if (imageno == 5)
            {
                imageno = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"images\{0}.jpg", imageno);
            imageno++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingnextimage();
        }

        private void issueBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void addNewBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            AddBooks abs = new AddBooks();
            abs.Show();

        }

        private void viewBooksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewBook vb = new ViewBook();
            vb.Show();
        }

        private void addStudentToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            AddStudent abs = new AddStudent();
            abs.Show();
        }

        private void viewStudentInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ViewStudentInfo view = new ViewStudentInfo();
            view.Show();
        }

        private void issueBooksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            IssueBooks iso = new IssueBooks();
            iso.Show();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are You Sure You Want To Exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void returnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBook rb = new ReturnBook();
            rb.Show();

        }

        private void completeBooksDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompleteBookDetails cb = new CompleteBookDetails();
            cb.Show();
        }
    }
}
