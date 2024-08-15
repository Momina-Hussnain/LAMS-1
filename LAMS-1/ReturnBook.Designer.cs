namespace LAMS_1
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            panel2 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearchStudent = new Button();
            txtEnterEnroll = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtBookName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnReturn = new Button();
            label4 = new Label();
            label5 = new Label();
            txtBookIssueDate = new TextBox();
            btnCancel = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSalmon;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearchStudent);
            panel2.Controls.Add(txtEnterEnroll);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 413);
            panel2.TabIndex = 3;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Salmon;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(107, 310);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Salmon;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Location = new Point(3, 310);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.BackColor = Color.LightSalmon;
            btnSearchStudent.FlatStyle = FlatStyle.Popup;
            btnSearchStudent.Location = new Point(37, 227);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(104, 23);
            btnSearchStudent.TabIndex = 4;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = false;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // txtEnterEnroll
            // 
            txtEnterEnroll.Location = new Point(16, 180);
            txtEnterEnroll.Name = "txtEnterEnroll";
            txtEnterEnroll.Size = new Size(156, 23);
            txtEnterEnroll.TabIndex = 3;
            txtEnterEnroll.TextChanged += txtEnterEnroll_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 128);
            label1.Name = "label1";
            label1.Size = new Size(194, 22);
            label1.TabIndex = 2;
            label1.Text = "Enter Enrollment No";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(234, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 82);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 10);
            label2.Name = "label2";
            label2.Size = new Size(104, 54);
            label2.TabIndex = 2;
            label2.Text = "RETURN \r\nBOOK\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(237, -9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(234, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(762, 220);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(271, 347);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(414, 341);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(148, 23);
            txtBookName.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(753, 341);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.DarkSlateBlue;
            btnReturn.FlatStyle = FlatStyle.Popup;
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(658, 392);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(75, 23);
            btnReturn.TabIndex = 8;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(271, 393);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 9;
            label4.Text = "Book Issue Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(613, 344);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 10;
            label5.Text = "Book Return Date";
            // 
            // txtBookIssueDate
            // 
            txtBookIssueDate.Location = new Point(414, 393);
            txtBookIssueDate.Name = "txtBookIssueDate";
            txtBookIssueDate.ReadOnly = true;
            txtBookIssueDate.Size = new Size(148, 23);
            txtBookIssueDate.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSlateBlue;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(791, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // ReturnBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(1008, 444);
            Controls.Add(btnCancel);
            Controls.Add(txtBookIssueDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnReturn);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtBookName);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ReturnBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReturnBook";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnExit;
        private Button btnRefresh;
        private Button btnSearchStudent;
        private TextBox txtEnterEnroll;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtBookName;
        private DateTimePicker dateTimePicker1;
        private Button btnReturn;
        private Label label4;
        private Label label5;
        private TextBox txtBookIssueDate;
        private Button btnCancel;
    }
}