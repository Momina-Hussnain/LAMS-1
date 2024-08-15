namespace LAMS_1
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            txtBookName = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            txtPDate = new TextBox();
            btnCancel = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtPublication = new TextBox();
            txtAuthor = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtBName = new TextBox();
            label3 = new Label();
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
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 119);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Turquoise;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(439, 46);
            label1.Name = "label1";
            label1.Size = new Size(140, 27);
            label1.TabIndex = 1;
            label1.Text = "VIEW BOOK";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(269, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(249, 138);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 1;
            label2.Text = "Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(344, 138);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(170, 23);
            txtBookName.TabIndex = 2;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(529, 137);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(971, 236);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(txtPDate);
            panel2.Controls.Add(btnCancel);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtQuantity);
            panel2.Controls.Add(txtPrice);
            panel2.Controls.Add(txtPublication);
            panel2.Controls.Add(txtAuthor);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtBName);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 409);
            panel2.Name = "panel2";
            panel2.Size = new Size(971, 233);
            panel2.TabIndex = 5;
            // 
            // txtPDate
            // 
            txtPDate.Location = new Point(565, 24);
            txtPDate.Name = "txtPDate";
            txtPDate.Size = new Size(136, 23);
            txtPDate.TabIndex = 15;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(827, 167);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(827, 100);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(827, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button2_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(565, 167);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(136, 23);
            txtQuantity.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(565, 96);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(136, 23);
            txtPrice.TabIndex = 10;
            // 
            // txtPublication
            // 
            txtPublication.Location = new Point(162, 162);
            txtPublication.Name = "txtPublication";
            txtPublication.Size = new Size(100, 23);
            txtPublication.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(162, 91);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(421, 175);
            label8.Name = "label8";
            label8.Size = new Size(89, 14);
            label8.TabIndex = 6;
            label8.Text = "Book Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(421, 100);
            label7.Name = "label7";
            label7.Size = new Size(70, 14);
            label7.TabIndex = 5;
            label7.Text = "Book Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(406, 33);
            label6.Name = "label6";
            label6.Size = new Size(134, 14);
            label6.TabIndex = 4;
            label6.Text = "Book Publication Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(37, 171);
            label5.Name = "label5";
            label5.Size = new Size(104, 14);
            label5.TabIndex = 3;
            label5.Text = "Book Publication";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 100);
            label4.Name = "label4";
            label4.Size = new Size(79, 14);
            label4.TabIndex = 2;
            label4.Text = "Book Author";
            // 
            // txtBName
            // 
            txtBName.Location = new Point(162, 29);
            txtBName.Name = "txtBName";
            txtBName.Size = new Size(100, 23);
            txtBName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(37, 33);
            label3.Name = "label3";
            label3.Size = new Size(74, 14);
            label3.TabIndex = 0;
            label3.Text = "Book Name";
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Turquoise;
            ClientSize = new Size(938, 431);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookName);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ViewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBook";
            Load += ViewBook_Load;
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
        private TextBox txtBookName;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Panel panel2;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtPublication;
        private TextBox txtAuthor;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtBName;
        private Label label3;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtPDate;
    }
}