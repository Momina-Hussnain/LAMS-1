namespace LAMS_1
{
    partial class ViewStudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewStudentInfo));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtEnrollment = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtSemester = new TextBox();
            txtDepartment = new TextBox();
            txtEnroll = new TextBox();
            txtSname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(528, 9);
            label1.Name = "label1";
            label1.Size = new Size(140, 66);
            label1.TabIndex = 1;
            label1.Text = "View \r\nStudent";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, -10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(295, 116);
            label2.Name = "label2";
            label2.Size = new Size(120, 18);
            label2.TabIndex = 1;
            label2.Text = "Enrollment No";
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(421, 116);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(166, 23);
            txtEnrollment.TabIndex = 2;
            txtEnrollment.TextChanged += txtEnrollment_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(609, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(971, 274);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtContact);
            panel2.Controls.Add(txtSemester);
            panel2.Controls.Add(txtDepartment);
            panel2.Controls.Add(txtEnroll);
            panel2.Controls.Add(txtSname);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(12, 448);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 262);
            panel2.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Cyan;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(577, 215);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Cyan;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(436, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Cyan;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(304, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(643, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(168, 23);
            txtEmail.TabIndex = 21;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(643, 97);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(168, 23);
            txtContact.TabIndex = 20;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(643, 31);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(168, 23);
            txtSemester.TabIndex = 19;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(209, 152);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(166, 23);
            txtDepartment.TabIndex = 18;
            // 
            // txtEnroll
            // 
            txtEnroll.Location = new Point(209, 88);
            txtEnroll.Name = "txtEnroll";
            txtEnroll.Size = new Size(166, 23);
            txtEnroll.TabIndex = 17;
            // 
            // txtSname
            // 
            txtSname.Location = new Point(209, 31);
            txtSname.Name = "txtSname";
            txtSname.Size = new Size(166, 23);
            txtSname.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(456, 156);
            label7.Name = "label7";
            label7.Size = new Size(87, 14);
            label7.TabIndex = 15;
            label7.Text = "Student Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(456, 97);
            label6.Name = "label6";
            label6.Size = new Size(98, 14);
            label6.TabIndex = 14;
            label6.Text = "Student contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(456, 35);
            label5.Name = "label5";
            label5.Size = new Size(111, 14);
            label5.TabIndex = 13;
            label5.Text = "Student Semester";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 156);
            label4.Name = "label4";
            label4.Size = new Size(76, 14);
            label4.TabIndex = 12;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 97);
            label3.Name = "label3";
            label3.Size = new Size(88, 14);
            label3.TabIndex = 11;
            label3.Text = "Enrollment No";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(58, 35);
            label8.Name = "label8";
            label8.Size = new Size(89, 14);
            label8.TabIndex = 10;
            label8.Text = "Student Name";
            // 
            // ViewStudentInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.IndianRed;
            ClientSize = new Size(970, 483);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtEnrollment);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ViewStudentInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewStudentInfo";
            Load += ViewStudentInfo_Load;
            Click += ViewStudentInfo_Click;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtEnrollment;
        private Button button1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtSemester;
        private TextBox txtDepartment;
        private TextBox txtEnroll;
        private TextBox txtSname;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
    }
}