namespace LAMS_1
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            txtName = new TextBox();
            btnRefresh = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEnrollment = new TextBox();
            txtDepartment = new TextBox();
            txtSemester = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 354);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 35);
            label1.Name = "label1";
            label1.Size = new Size(162, 27);
            label1.TabIndex = 2;
            label1.Text = "ADD Student";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(222, -9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(141, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(297, 111);
            label2.Name = "label2";
            label2.Size = new Size(89, 14);
            label2.TabIndex = 2;
            label2.Text = "Student Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(450, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 23);
            txtName.TabIndex = 3;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Cyan;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(298, 393);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(298, 151);
            label3.Name = "label3";
            label3.Size = new Size(88, 14);
            label3.TabIndex = 5;
            label3.Text = "Enrollment No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(298, 196);
            label4.Name = "label4";
            label4.Size = new Size(76, 14);
            label4.TabIndex = 6;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(298, 248);
            label5.Name = "label5";
            label5.Size = new Size(111, 14);
            label5.TabIndex = 7;
            label5.Text = "Student Semester";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(298, 296);
            label6.Name = "label6";
            label6.Size = new Size(98, 14);
            label6.TabIndex = 8;
            label6.Text = "Student contact";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(298, 347);
            label7.Name = "label7";
            label7.Size = new Size(87, 14);
            label7.TabIndex = 9;
            label7.Text = "Student Email";
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(450, 151);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(149, 23);
            txtEnrollment.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(450, 196);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(149, 23);
            txtDepartment.TabIndex = 11;
            // 
            // txtSemester
            // 
            txtSemester.Location = new Point(450, 244);
            txtSemester.Name = "txtSemester";
            txtSemester.Size = new Size(149, 23);
            txtSemester.TabIndex = 12;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(450, 292);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(149, 23);
            txtContact.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(450, 338);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(149, 23);
            txtEmail.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Cyan;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(430, 393);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save Info";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Cyan;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(571, 393);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 16;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(684, 428);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtSemester);
            Controls.Add(txtDepartment);
            Controls.Add(txtEnrollment);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnRefresh);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Button btnRefresh;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEnrollment;
        private TextBox txtDepartment;
        private TextBox txtSemester;
        private TextBox txtContact;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnExit;
    }
}